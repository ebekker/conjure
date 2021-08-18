using System;
using System.IO;
using Conjure.EFX.Impl;
using Conjure.EFX.SourceGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Conjure.EFX.SourceGenerator
{
    //
    // TODO:  
    //    https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#package-a-generator-as-a-nuget-package
    // 

    // This is disabled until we figure out the dependency issues with Logging and DI extensions
    // [Generator]

    public class EFXSourceGenerator : ISourceGenerator
    {
        IServiceProvider _services;

        IProfileOptionsSerializer _serializer;
        IModelCacheBuilder _cacheBuilder;
        ICodeGenerator _codeGenerator;

        public void Initialize(GeneratorInitializationContext context)
        {
            var services = new ServiceCollection();

            services.AddLogging(builder =>
            {
                // // Clear all existing logging providers and install NLog
                // builder.ClearProviders();
                // builder.SetMinimumLevel(LogLevel.Trace);
                // builder.AddNLog();
            });
            services.AddTransient<IProfileOptionsSerializer, ProfileOptionsSerializer>();
            services.AddTransient<IModelCacheBuilder, ModelCacheBuilder>();
            services.AddTransient<ICodeGenerator, CodeGenerator>();

            _services = services.BuildServiceProvider();
            _serializer = _services.GetRequiredService<IProfileOptionsSerializer>();
            _cacheBuilder = _services.GetRequiredService<IModelCacheBuilder>();
            _codeGenerator = _services.GetRequiredService<ICodeGenerator>();
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var profiles = ProfileInfo.GetProfiles();
            foreach (var p in profiles)
            {
                

                var cache = Path.Combine(p.ProfilePath, ModelCacheBuilder.DefaultModelCacheFileName);
                if (File.Exists(cache))
                {
                    context.ReportDiagnostic(Diagnostic.Create("EFX-0", "EFX",
                        $"Found EFX DB Model Cache: {cache}",
                        DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 1));
                }
                else
                {
                    context.ReportDiagnostic(Diagnostic.Create("EFX-0", "EFX",
                        $"Did not find DB Model Cache for profile: {p.ProfilePath}",
                        DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 1));
                }
            }
        }
    }
}
