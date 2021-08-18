using System;
using System.Threading.Tasks;
using Conjure.EFX.DotNetTool.CommandLine;
using Conjure.EFX.Impl;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace Conjure.EFX.DotNetTool
{
    [Subcommand(
        typeof(ListCommand),
        typeof(RefreshCommand),
        typeof(PreviewCommand),
        typeof(PipeGenCommand),
        typeof(PipeTestCommand)
    )]
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            var cla = new CommandLineApplication<Program>();

            cla.Conventions
                .UseDefaultConventions()
                .UseConstructorInjection(ConfigureServices());

            return await cla.ExecuteAsync(args);
        }

        public void OnExecute(CommandLineApplication cla) => cla.ShowHelp();

        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddLogging(builder =>
            {
                // Clear all existing logging providers and install NLog
                builder.ClearProviders();
                builder.SetMinimumLevel(LogLevel.Trace);
                builder.AddNLog();
            });

            services.AddTransient<IProfileOptionsSerializer, ProfileOptionsSerializer>();
            services.AddTransient<IModelCacheBuilder, ModelCacheBuilder>();
            services.AddTransient<ICodeGenerator, CodeGenerator>();

            return services.BuildServiceProvider();
        }
    }
}
