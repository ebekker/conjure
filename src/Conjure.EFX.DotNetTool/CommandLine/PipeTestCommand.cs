using Conjure.PipeTalk;
using McMaster.Extensions.CommandLineUtils;
using System.Diagnostics;
using System.IO.Pipes;

namespace Conjure.EFX.DotNetTool.CommandLine
{
    [Command(ShowInHelpText = false)]
    public class PipeTestCommand : BaseCommand
    {
        public void OnExecute()
        {
            var pipeName = Guid.NewGuid().ToString();

            Console.WriteLine("Starting PipeGen Server");
            //Process.Start("dotnet", $"tool run efx -- pipe-gen --pipe-name {pipeName}");
            Process.Start("dotnet", $"run -- pipe-gen --pipe-name {pipeName}");
            Console.WriteLine("STARTED");

            using var client = OutProcGenProtocol.CreateClient(pipeName);
            client.Connect();
            client.BeginSession();
            client.ReadProfiles((profile, path, content) =>
            {
                var name = path
                    .Replace("\\", "__")
                    .Replace("/", "__");

                Console.WriteLine($"Got file: {profile}, {name}:");
                Console.WriteLine($"  Length: {content.Length}");
                //Console.WriteLine("--8<---------------------------------------------------------------");
                //Console.WriteLine(content);
                //Console.WriteLine("--------------------------------------------------------------->8--");
            });


            // var content = reader.ReadToEnd();
            // Console.WriteLine("GOT:");
            // Console.WriteLine("--8<---------------------------------------------------------------");
            // Console.WriteLine(content);
            // Console.WriteLine("--------------------------------------------------------------->8--");
        }
    }
}
