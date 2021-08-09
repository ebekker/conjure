using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Conjure.NScribe.ScribanImpl;
using Microsoft.CodeAnalysis;
using Scriban;
using Scriban.Helpers;
using Scriban.Parsing;
using Scriban.Runtime;
using Scriban.Runtime.Accessors;

namespace Conjure.NScribe
{
    [Generator]
    public class NScribeSourceGenerator : ISourceGenerator
    {
        public static string ConfigMarker = ".nscribe/";
        public static string ScribanExt = ".scriban-cs";

        public void Initialize(GeneratorInitializationContext context)
        {
            // TODO;
        }

        public void Execute(GeneratorExecutionContext context)
        {
            // var x = context.AnalyzerConfigOptions;
            // var y = context.AdditionalFiles;
            // var z = context.Compilation;
            // var a = context.ParseOptions;

            var configs = new List<string>();
            var configFiles = new Dictionary<string, List<string>>();

            foreach (var af in context.AdditionalFiles)
            {
                var canonPath = af.Path.Replace("\\", "/");
                var markerNdx = canonPath.IndexOf(ConfigMarker);
                if (markerNdx > 0)
                {
                    var configPath = canonPath.Substring(0, markerNdx + ConfigMarker.Length);

                    if (!configs.Contains(configPath))
                    {
                        configs.Add(configPath);
                        configFiles.Add(configPath, new());

                        // context.ReportDiagnostic(Diagnostic.Create("NSCRIBE-0", "NSCRIBE",
                        //     $"Found NScribe Config Path: {configPath}",
                        //     DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 1));
                    }
                    configFiles[configPath].Add(canonPath);

                    // context.ReportDiagnostic(Diagnostic.Create("NSCRIBE-0", "NSCRIBE",
                    //     $"Found NScribe Config File Path: {canonPath}",
                    //     DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 1));
                }
            }

            foreach (var config in configs)
            {
                var configShortName = Path.GetFileName(Path.GetDirectoryName(config));
                var templateLoader = new NScribeTemplateLoader
                {
                    ConfigPath = config,
                };

                context.ReportDiagnostic(Diagnostic.Create("NSCRIBE-0", "NSCRIBE",
                    $"Found NScribe Config Path: {configShortName} {config}",
                    DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 1));

                var files = configFiles[config].Where(x => x.EndsWith(ScribanExt));
                foreach (var asset in files)
                {
                    var assetShortName = Path.GetFileName(asset);
                    var sourceName = $"{configShortName}/{assetShortName}".Replace("/", "__");

                    context.ReportDiagnostic(Diagnostic.Create("NSCRIBE-0", "NSCRIBE",
                        $"Found NScribe Config Asset Path: {assetShortName} : {asset} : {sourceName}",
                        DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 1));

                    var nscribeContext = new NScribeContext(context);
                    var scriptObject = new ScriptObject();
                    scriptObject.Import(typeof(MethodSupport));
                    scriptObject.Import(nscribeContext, SimpleFilter, SimpleRenamer);
                    var templateContext = new NScribeTemplateContext
                    {
                        MemberFilter = SimpleFilter,
                        MemberRenamer = SimpleRenamer,
                        TemplateLoader = templateLoader,
                    };
                    templateContext.PushGlobal(scriptObject);

                    var content = File.ReadAllText(asset);
                    var template = Template.Parse(content, asset);
                    var source = template.Render(templateContext);
                    context.AddSource(sourceName, source);
                }
            }



            // find the main method
            var mainMethod = context.Compilation.GetEntryPoint(context.CancellationToken);
            var clsName = mainMethod.ContainingType.Name;
            var nsName = mainMethod.ContainingNamespace.ToDisplayString(null);
            var foo = (ISymbol)mainMethod.ContainingNamespace;
            foo.ToDisplayString(null);

//             // build up the source code
//             string source = $@"
// using System;

// namespace {nsName}
// {{
//     public partial class {clsName}
//     {{
//         static partial void HelloFrom(string name)
//         {{
//             Console.WriteLine($""Generator says {DateTime.Now}: Hi from '{{name}}'"");
//         }}
//     }}
// }}
// ";
            // context.ReportDiagnostic(Diagnostic.Create("NSCRIBE-0", "NSCRIBE",
            //     $"Generating for namespace: {nsName}",
            //     DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 1));

            // context.ReportDiagnostic(Diagnostic.Create("NSCRIBE-0", "NSCRIBE",
            //     $"Generating for class name: {clsName}",
            //     DiagnosticSeverity.Info, DiagnosticSeverity.Info, true, 4));

            // add the source code to the compilation
            // context.AddSource("generatedSource", source);
        }

        private static string SimpleRenamer(MemberInfo member) => member.Name;
        private static bool SimpleFilter(MemberInfo member) => true;
    }

    class NScribeTemplateLoader : ITemplateLoader
    {
        public string ConfigPath { get; init; }
        
        public string GetPath(TemplateContext context, SourceSpan callerSpan, string templateName)
        {
            return Path.Combine(ConfigPath, templateName);
        }

        public string Load(TemplateContext context, SourceSpan callerSpan, string templatePath)
        {
            return File.ReadAllText(templatePath);
        }

        public ValueTask<string> LoadAsync(TemplateContext context, SourceSpan callerSpan, string templatePath)
        {
            // We don't really support async I/O within a
            // source generator so no need to implement this
            throw new NotImplementedException();
        }
    }
}
