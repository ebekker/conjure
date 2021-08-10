using Conjure.EFX.Generation;
using Conjure.EFX.Options;
using Conjure.NScribe.ScribanImpl;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Scriban;
using Scriban.Runtime;

namespace Conjure.EFX.Impl
{
    public class CodeGenerator : ICodeGenerator
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly ILogger _logger;
        private readonly ModelGenerator _modelGenerator;

        private string[] _topTemplates;
        private string[] _entityTemplates;
        private string[] _entityModelTemplates;

        public CodeGenerator(ILoggerFactory logger)
        {
            _loggerFactory = logger;
            _logger = logger.CreateLogger<CodeGenerator>();
            _modelGenerator = new ModelGenerator(logger);
        }

        public ProfileOptions Options { get; set; }

        public void Generate(ProfileOptions options, DatabaseModel databaseModel)
        {
            Options = options ?? throw new ArgumentNullException(nameof(options));

            var databaseProviders = GetDatabaseProviders();

            _logger.LogInformation("Loaded database model for: {databaseName}", databaseModel.DatabaseName);

            var context = _modelGenerator.Generate(Options, databaseModel, databaseProviders.mapping);

            var topTemplatesPath = Path.GetFullPath(Path.Combine(Options.Options.ProfilePath, "templates"));
            _topTemplates = Directory.GetFiles(topTemplatesPath, "*.scriban-cs", SearchOption.TopDirectoryOnly);
            var childTemplatesPath = Path.GetFullPath(Path.Combine(topTemplatesPath, "entities"));
            _entityTemplates = Directory.GetFiles(childTemplatesPath, "*.scriban-cs", SearchOption.TopDirectoryOnly);
            childTemplatesPath = Path.GetFullPath(Path.Combine(topTemplatesPath, "entities/models"));
            _entityModelTemplates = Directory.GetFiles(childTemplatesPath, "*.scriban-cs", SearchOption.TopDirectoryOnly);

            GenerateFiles(context);
        }

        public class EFXGeneratorContext
        {
            public ProfileOptions Options { get; init; }
            public EntityContext EntityContext { get; init; }

            public Model EntityModel { get; set; }
        }

        private void GenerateFiles(EntityContext entityContext)
        {
            Entity targetEntity = null;

            var genContext = new EFXGeneratorContext
            {
                Options = Options,
                EntityContext = entityContext,
            };
            var scriptObject = new ScriptObject();
            scriptObject.Import(typeof(MethodSupport));
            scriptObject.Import(typeof(GenerationExtensions));
            scriptObject.Import(genContext, renamer: mi => mi.Name);
            scriptObject.Import("Entity", () => targetEntity);
            var templateContext = new TemplateContext
            {
                MemberRenamer = mi => mi.Name,
            };
            templateContext.PushGlobal(scriptObject);

            foreach (var templatePath in _topTemplates)
            {
                GenerateTemplateFile(entityContext, templatePath, templateContext);
            }

            if (_entityTemplates.Length > 0)
            {
                foreach (var entity in entityContext.Entities)
                {
                    Options.Variables.Set(entity);
                    targetEntity = entity;

                    foreach (var templatePath in _entityTemplates)
                    {
                        GenerateTemplateFile(entityContext, templatePath, templateContext, "entities");

                        if (_entityModelTemplates.Length > 0 && entity.Models.Count > 0)
                        {
                            foreach (var model in entity.Models)
                            {
                                Options.Variables.Set(model);
                                genContext.EntityModel = model;

                                foreach (var modelTemplatePath in _entityModelTemplates)
                                {
                                    GenerateTemplateFile(entityContext, templatePath, templateContext, "entities/models");
                                }

                                genContext.EntityModel = null;
                                Options.Variables.Remove(model);
                            }
                        }
                    }

                    Options.Variables.Remove(entity);
                }
            }

            // GenerateDataContext(entityContext);
            // GenerateEntityClasses(entityContext);
            // GenerateMappingClasses(entityContext);

            // if (Options.Data.Query.Generate)
            //     GenerateQueryExtensions(entityContext);

            // GenerateModelClasses(entityContext);

            // GenerateScriptTemplates(entityContext);
        }

        private void GenerateTemplateFile(EntityContext entityContext,
            string templatePath, TemplateContext templateContext, string outputPrefix = null)
        {
            var templateName = Path.GetFileNameWithoutExtension(templatePath);
            var outputPath = Path.Combine(Options.Project.Directory, "preview", outputPrefix??"", $"{templateName}.cs");
            outputPath = Path.GetFullPath(outputPath);
            outputPath = Options.Variables.Evaluate(outputPath);
            _logger.LogInformation("Generating from template [{0}] to [{1}]", templateName, outputPath);

            var outputDir = Path.GetDirectoryName(outputPath);
            Directory.CreateDirectory(outputDir);

            var content = File.ReadAllText(templatePath);
            var template = Template.Parse(content);
            var output = template.Render(templateContext);
            File.WriteAllText(outputPath, output);
        }

        private void GenerateDataContext(EntityContext entityContext)
        {

            var directory = Options.Data.Context.Directory;
            var file = entityContext.ContextClass + ".cs";
            var path = Path.Combine(directory, file);

            _logger.LogInformation(File.Exists(path)
                ? "Updating data context class: {file}"
                : "Creating data context class: {file}", file);

            // var template = new DataContextTemplate(entityContext, Options);
            // template.WriteCode(path);
        }

        private void GenerateEntityClasses(EntityContext entityContext)
        {
            foreach (var entity in entityContext.Entities)
            {
                Options.Variables.Set(entity);

                var directory = Options.Data.Entity.Directory;
                var file = entity.EntityClass + ".cs";
                var path = Path.Combine(directory, file);

                _logger.LogInformation(File.Exists(path)
                    ? "Updating entity class: {file}"
                    : "Creating entity class: {file}", file);

                // var template = new EntityClassTemplate(entity, Options);
                // template.WriteCode(path);

                Options.Variables.Remove(entity);
            }
        }

        private void GenerateMappingClasses(EntityContext entityContext)
        {
            foreach (var entity in entityContext.Entities)
            {
                Options.Variables.Set(entity);

                var directory = Options.Data.Mapping.Directory;
                var file = entity.MappingClass + ".cs";
                var path = Path.Combine(directory, file);

                _logger.LogInformation(File.Exists(path)
                    ? "Updating mapping class: {file}"
                    : "Creating mapping class: {file}", file);

                // var template = new MappingClassTemplate(entity, Options);
                // template.WriteCode(path);

                Options.Variables.Remove(entity);
            }
        }

        private void GenerateQueryExtensions(EntityContext entityContext)
        {
            foreach (var entity in entityContext.Entities)
            {
                Options.Variables.Set(entity);

                var directory = Options.Data.Query.Directory;
                var file = entity.EntityClass + "Extensions.cs";
                var path = Path.Combine(directory, file);

                _logger.LogInformation(File.Exists(path)
                    ? "Updating query extensions class: {file}"
                    : "Creating query extensions class: {file}", file);

                // var template = new QueryExtensionTemplate(entity, Options);
                // template.WriteCode(path);

                Options.Variables.Remove(entity);
            }
        }

        private void GenerateModelClasses(EntityContext entityContext)
        {
            foreach (var entity in entityContext.Entities)
            {
                if (entity.Models.Count <= 0)
                    continue;

                Options.Variables.Set(entity);

                GenerateModelClasses(entity);
                GenerateValidatorClasses(entity);
                GenerateMapperClass(entity);

                Options.Variables.Remove(entity);
            }
        }


        private void GenerateModelClasses(Entity entity)
        {
            foreach (var model in entity.Models)
            {
                Options.Variables.Set(model);

                var directory = GetModelDirectory(model);
                var file = model.ModelClass + ".cs";
                var path = Path.Combine(directory, file);

                _logger.LogInformation(File.Exists(path)
                    ? "Updating model class: {file}"
                    : "Creating model class: {file}", file);


                // var template = new ModelClassTemplate(model, Options);
                // template.WriteCode(path);

                Options.Variables.Remove(model);
            }

        }

        private string GetModelDirectory(Model model)
        {
            if (model.ModelType == ModelType.Create)
                return !string.IsNullOrEmpty(Options.Model.Create.Directory)
                    ? Options.Model.Create.Directory
                    : Options.Model.Shared.Directory;

            if (model.ModelType == ModelType.Update)
                return !string.IsNullOrEmpty(Options.Model.Update.Directory)
                    ? Options.Model.Update.Directory
                    : Options.Model.Shared.Directory;

            return !string.IsNullOrEmpty(Options.Model.Read.Directory)
                ? Options.Model.Read.Directory
                : Options.Model.Shared.Directory;
        }


        private void GenerateValidatorClasses(Entity entity)
        {
            if (!Options.Model.Validator.Generate)
                return;

            foreach (var model in entity.Models)
            {
                Options.Variables.Set(model);

                // don't validate read models
                if (model.ModelType == ModelType.Read)
                    continue;

                var directory = Options.Model.Validator.Directory;
                var file = model.ValidatorClass + ".cs";
                var path = Path.Combine(directory, file);

                _logger.LogInformation(File.Exists(path)
                    ? "Updating validation class: {file}"
                    : "Creating validation class: {file}", file);

                // var template = new ValidatorClassTemplate(model, Options);
                // template.WriteCode(path);

                Options.Variables.Remove(model);
            }
        }


        private void GenerateMapperClass(Entity entity)
        {
            if (!Options.Model.Mapper.Generate)
                return;

            var directory = Options.Model.Mapper.Directory;
            var file = entity.MapperClass + ".cs";
            var path = Path.Combine(directory, file);

            _logger.LogInformation(File.Exists(path)
                ? "Updating object mapper class: {file}"
                : "Creating object mapper class: {file}", file);

            // var template = new MapperClassTemplate(entity, Options);
            // template.WriteCode(path);
        }


        private void GenerateScriptTemplates(EntityContext entityContext)
        {
            GenerateContextScriptTemplates(entityContext);
            GenerateEntityScriptTemplates(entityContext);
            GenerateModelScriptTemplates(entityContext);
        }

        private void GenerateModelScriptTemplates(EntityContext entityContext)
        {
            if (Options?.Script?.Model == null || Options.Script.Model.Count == 0)
                return;

            foreach (var templateOption in Options.Script.Model)
            {
                if (!VerifyScriptTemplate(templateOption))
                    continue;

                try
                {
                    // var template = new ModelScriptTemplate(_loggerFactory, Options, templateOption);

                    // foreach (var entity in entityContext.Entities)
                    // {
                    //     Options.Variables.Set(entity);

                    //     foreach (var model in entity.Models)
                    //     {
                    //         Options.Variables.Set(model);

                    //         template.RunScript(model);

                    //         Options.Variables.Remove(model);
                    //     }

                    //     Options.Variables.Remove(entity);
                    // }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error Running Model Template: {message}", ex.Message);
                }
            }
        }

        private void GenerateEntityScriptTemplates(EntityContext entityContext)
        {
            if (Options?.Script?.Entity == null || Options.Script.Entity.Count == 0)
                return;

            foreach (var templateOption in Options.Script.Entity)
            {
                if (!VerifyScriptTemplate(templateOption))
                    continue;

                try
                {
                    // var template = new EntityScriptTemplate(_loggerFactory, Options, templateOption);

                    // foreach (var entity in entityContext.Entities)
                    // {
                    //     Options.Variables.Set(entity);

                    //     template.RunScript(entity);

                    //     Options.Variables.Remove(entity);
                    // }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error Running Entity Template: {message}", ex.Message);
                }
            }
        }

        private void GenerateContextScriptTemplates(EntityContext entityContext)
        {
            if (Options?.Script?.Context == null || Options.Script.Context.Count !< 0)
                return;

            foreach (var templateOption in Options.Script.Context)
            {
                if (!VerifyScriptTemplate(templateOption))
                    continue;

                try
                {
                    // var template = new ContextScriptTemplate(_loggerFactory, Options, templateOption);
                    // template.RunScript(entityContext);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error Running Context Template: {message}", ex.Message);
                }
            }
        }

        private bool VerifyScriptTemplate(TemplateOptions templateOption)
        {
            var templatePath = templateOption.TemplatePath;

            if (File.Exists(templatePath))
                return true;

            _logger.LogWarning("Template '{template}' could not be found.", templatePath);
            return false;
        }


        private DatabaseModel GetDatabaseModel(IDatabaseModelFactory factory)
        {
            _logger.LogInformation("Loading database model ...");

            var database = Options.Database;
            var connectionString = ResolveConnectionString(database);
            var options = new DatabaseModelFactoryOptions(database.Tables, database.Schemas);

            return factory.Create(connectionString, options);
        }

        private string ResolveConnectionString(DatabaseOptions database)
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


        private (IDatabaseModelFactory factory, IRelationalTypeMappingSource mapping) GetDatabaseProviders()
        {
            var provider = Options.Database.Provider;
            var dtsClassName = Options.Database.ProviderDesignTimeServicesClass;

            _logger.LogDebug("Creating database model factory for: {provider}", provider);

            // start a new service container to create the database model factory
            var services = new ServiceCollection()
                .AddSingleton(_loggerFactory)
                .AddEntityFrameworkDesignTimeServices();

            var dts = ModelCacheBuilder.GetDesignTimeServices(provider, dtsClassName);
            dts.ConfigureDesignTimeServices(services);

            // switch (provider)
            // {
            //     case DatabaseProviders.SqlServer:
            //         ConfigureSqlServerServices(services);
            //         break;
            //     case DatabaseProviders.PostgreSQL:
            //         ConfigurePostgresServices(services);
            //         break;
            //     case DatabaseProviders.MySQL:
            //         ConfigureMySqlServices(services);
            //         break;
            //     case DatabaseProviders.Sqlite:
            //         ConfigureSqliteServices(services);
            //         break;
            //     case DatabaseProviders.Oracle:
            //         ConfigureOracleServices(services);
            //         break;
            //     default:
            //         throw new NotSupportedException($"The specified provider '{provider}' is not supported.");
            // }

            var serviceProvider = services
                .BuildServiceProvider();

            var databaseModelFactory = serviceProvider
                .GetRequiredService<IDatabaseModelFactory>();

            var typeMappingSource = serviceProvider
                .GetRequiredService<IRelationalTypeMappingSource>();

            return (databaseModelFactory, typeMappingSource);
        }


        // private void ConfigureMySqlServices(IServiceCollection services)
        // {
        //     var designTimeServices = new Pomelo.EntityFrameworkCore.MySql.Design.Internal.MySqlDesignTimeServices();
        //     designTimeServices.ConfigureDesignTimeServices(services);
        // }

        // private void ConfigurePostgresServices(IServiceCollection services)
        // {
        //     var designTimeServices = new Npgsql.EntityFrameworkCore.PostgreSQL.Design.Internal.NpgsqlDesignTimeServices();
        //     designTimeServices.ConfigureDesignTimeServices(services);
        // }

        // private void ConfigureSqlServerServices(IServiceCollection services)
        // {
        //     var designTimeServices = new Microsoft.EntityFrameworkCore.SqlServer.Design.Internal.SqlServerDesignTimeServices();
        //     designTimeServices.ConfigureDesignTimeServices(services);
        // }

        // private void ConfigureSqliteServices(IServiceCollection services)
        // {
        //     var designTimeServices = new Microsoft.EntityFrameworkCore.Sqlite.Design.Internal.SqliteDesignTimeServices();
        //     designTimeServices.ConfigureDesignTimeServices(services);
        // }

        // private void ConfigureOracleServices(IServiceCollection services)
        // {
        //     var designTimeServices = new Oracle.EntityFrameworkCore.Design.Internal.OracleDesignTimeServices();
        //     designTimeServices.ConfigureDesignTimeServices(services);
        // }
    }
}