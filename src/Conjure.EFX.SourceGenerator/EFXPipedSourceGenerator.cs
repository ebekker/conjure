using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using Conjure.PipeTalk;
using Microsoft.CodeAnalysis;

namespace Conjure.EFX.SourceGenerator
{
    [Generator]
    public class EFXPipedSourceGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            // TODO:
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var pipeName = Guid.NewGuid().ToString();

            context.ReportDiagnostic(Diagnostic.Create("EFX-0", "EFX",
                $"Starting EFX Pipe Generator Server...",
                DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 1));

            var proc = Process.Start("dotnet", $"tool run efx -- pipe-gen --pipe-name {pipeName}");

            context.ReportDiagnostic(Diagnostic.Create("EFX-0", "EFX",
                $"...STARTED: {pipeName} - {proc.Id}",
                DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 1));

            using var client = OutProcGenProtocol.CreateClient(pipeName);

            context.ReportDiagnostic(Diagnostic.Create("EFX-0", "EFX",
                "Connecting to EFX Pipe Generator Server...",
                DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 1));
            client.Connect();
            context.ReportDiagnostic(Diagnostic.Create("EFX-0", "EFX",
                "...CONNECTED",
                DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 1));

            int sources = 0;
            client.BeginSession();
            client.ReadProfiles((profile, path, content) =>
            {
                var name = path
                    .Replace("\\", "__")
                    .Replace("/", "__")
                    .Replace(":", "__");
                context.AddSource(name, content);
                sources++;
            });

            context.ReportDiagnostic(Diagnostic.Create("EFX-0", "EFX",
                $"Added source files: [{sources}]",
                DiagnosticSeverity.Warning, DiagnosticSeverity.Warning, true, 1));

        }
    }
}