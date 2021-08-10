using System.Linq;
using Conjure.EFX.ModelCache;
using Conjure.EFX.Options;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Conjure.EFX.Impl
{
    public class ModelCacheBuilder : IModelCacheBuilder
    {
        public const string DefaultModelCacheFileName = "dbmodel.cache.json";

        // These are defined as string and resolved dynamically, so
        // that we don't need to include any strong package dependencies
        private static readonly IReadOnlyDictionary<DatabaseProviders, string> DatabaseProviderDtsClasses =
            new Dictionary<DatabaseProviders, string>()
            {
                [DatabaseProviders.MySQL] = "Pomelo.EntityFrameworkCore.MySql.Design.Internal.MySqlDesignTimeServices",
                [DatabaseProviders.PostgreSQL] = "Npgsql.EntityFrameworkCore.PostgreSQL.Design.Internal.NpgsqlDesignTimeServices",
                [DatabaseProviders.Oracle] = "Oracle.EntityFrameworkCore.Design.Internal.OracleDesignTimeServices",
                [DatabaseProviders.Sqlite] = "Microsoft.EntityFrameworkCore.Sqlite.Design.Internal.SqliteDesignTimeServices",
                [DatabaseProviders.SqlServer] =
                    //"Microsoft.EntityFrameworkCore.SqlServer.Design.Internal.SqlServerDesignTimeServices",
                    "Microsoft.EntityFrameworkCore.SqlServer.Design.Internal.SqlServerDesignTimeServices, Microsoft.EntityFrameworkCore.SqlServer",
            };

        private readonly ILogger _logger;

        public ModelCacheBuilder(ILogger<ModelCacheBuilder> logger)
        {
            _logger = logger;
        }

        public bool RefreshCache(ProfileOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            return RefreshFromScratch(options);
        }

        public DatabaseModel LoadFromCache(ProfileOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            var dir = Path.GetFullPath(options.Project.Directory);
            var ser = Path.Combine(dir, DefaultModelCacheFileName);

            _logger.LogInformation("Computed DB model cache file: {modelCacheFile}", ser);

            if (!File.Exists(ser))
            {
                throw new Exception("No cached database model found; did you generate it?");
            }

            var dbModel = Deserialize(File.ReadAllText(ser));

            return dbModel;
        }

        static internal IDesignTimeServices GetDesignTimeServices(DatabaseProviders? provider, string dtsClassName = null)
        {
            if (string.IsNullOrEmpty(dtsClassName))
            {
                if (provider == null
                    || !DatabaseProviderDtsClasses.TryGetValue(provider.Value, out dtsClassName))
                {
                    throw new NotSupportedException($"The specified provider [{provider}] DTS class could not be resolved, and no custom class was specified");
                }
            }

            var dtsClass = Type.GetType(dtsClassName);
            if (dtsClass == null)
            {
                // foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
                // {
                //     Console.Error.WriteLine("  * Looking in ASM: " + a.FullName);
                //     dtsClass = a.GetType(dtsClassName);
                //     if (dtsClass != null)
                //     {
                //         break;
                //     }
                // }

                if (dtsClass == null)
                {
                    throw new NotSupportedException($"Could not resolve DTS for provider class [{dtsClassName}]");
                }
            }

            IDesignTimeServices dts = (IDesignTimeServices)Activator.CreateInstance(dtsClass);
            if (dts == null)
            {
                throw new NotSupportedException($"Could not resolve DTS class for provider class [{dtsClassName}]");
            }

            return dts;
        }

        private bool RefreshFromScratch(ProfileOptions options)
        {
            var services = new ServiceCollection();

            _logger.LogInformation("Adding EF Design-time Services");
            services.AddEntityFrameworkDesignTimeServices();

            // This part is DB-specific
            var provider = options.Database.Provider;
            var dtsClassName = options.Database.ProviderDesignTimeServicesClass;

            var dts = GetDesignTimeServices(provider, dtsClassName);
            dts.ConfigureDesignTimeServices(services);

            var serviceProviders = services.BuildServiceProvider();
            var dbmFactory = serviceProviders.GetRequiredService<IDatabaseModelFactory>();
            var tmSource = serviceProviders.GetRequiredService<IRelationalTypeMappingSource>();

            var connectionString = ResolveConnectionString(options.Database);
            var dbmFactoryOptions = new DatabaseModelFactoryOptions(
                tables: options.Database.Tables, // null to include all
                schemas: options.Database.Schemas // null to include all
            );

            // Extract the Database Model
            _logger.LogInformation("Building DB Model");
            var dbModel = dbmFactory.Create(connectionString, dbmFactoryOptions);

            // Add a few of our own annotations for additional context
            dbModel.AddAnnotation("EFX:CreatedTime",
                DateTime.Now);
            dbModel.AddAnnotation("EFX:CLRVersion",
                System.Environment.Version);
            dbModel.AddAnnotation("EFX:OS",
                System.Environment.OSVersion);
            dbModel.AddAnnotation("EFX:CLI",
                System.Environment.CommandLine);
            dbModel.AddAnnotation("EFX:Args",
                System.Environment.GetCommandLineArgs().ToList());

            var dir = Path.GetFullPath(options.Project.Directory);
            var ser = Path.Combine(dir, DefaultModelCacheFileName);
            _logger.LogInformation("Computed DB model cache file: {modelCacheFile}", ser);

            Directory.CreateDirectory(dir);
            File.WriteAllText(ser, Serialize(dbModel));
            _logger.LogInformation("Serialized DB Model to cache file");

            return true;
        }

        public static string ResolveConnectionString(DatabaseOptions database)
        {
            if (!string.IsNullOrEmpty(database.ConnectionString))
                return database.ConnectionString;

            if (!string.IsNullOrEmpty(database.UserSecretsId))
            {
                var secretsStore = new SecretsStore(database.UserSecretsId);
                if (secretsStore.ContainsKey(database.ConnectionName))
                    return secretsStore[database.ConnectionName];
            }

            throw new InvalidOperationException("Could not find connection string.");
        }

        static JsonSerializerSettings Settings { get; }

        static ModelCacheBuilder()
        {
            Settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DefaultValueHandling = DefaultValueHandling.Include,
                TypeNameHandling = TypeNameHandling.All,
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                Converters = {
                    KeyValueTuplesJsonConverter.Instance,
                    AnnotationsJsonConverter.Instance,
                },
                ContractResolver = AnnotationsContractResolver.Instance,
            };
        }

        public static string Serialize(DatabaseModel model)
        {
            return JsonConvert.SerializeObject(model, Settings);
        }

        public static DatabaseModel Deserialize(string ser)
        {
            return JsonConvert.DeserializeObject<DatabaseModel>(ser, Settings);
        }
    }
}