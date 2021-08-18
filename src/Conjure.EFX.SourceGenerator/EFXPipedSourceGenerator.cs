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

            Process.Start("dotnet", $"tool run efx -- pipe-gen --pipe-name {pipeName}");

            using var client = OutProcGenProtocol.CreateClient(pipeName);
            client.Connect();
            client.BeginSession();
            client.ReadProfiles((profile, path, content) =>
            {
                var name = path
                    .Replace("\\", "__")
                    .Replace("/", "__")
                    .Replace(":", "__");
                context.AddSource(name, content);
            });
        }
    }
}