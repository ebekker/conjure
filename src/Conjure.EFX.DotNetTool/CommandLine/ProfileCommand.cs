using System.Text.Json;
using System.Text.Json.Serialization;
using McMaster.Extensions.CommandLineUtils;

namespace Conjure.EFX.DotNetTool.CommandLine
{
    [Command(Description = "show the resolved details and attributes of a Profile")]
    public class ProfileCommand : BaseCommand
    {
        private readonly IProfileOptionsSerializer _serializer;

        public ProfileCommand(IProfileOptionsSerializer serializer)
        {
            _serializer = serializer;
        }

        [Argument(0, Description = "name of the profile for which to show details")]
        public string Profile { get; set; }

        public int OnExecute()
        {
            if (Profile == null)
            {
                Console.Error.WriteLine("You must specify a profile name for which to generate code");
                return -1;
            }

            var profile = GetProfiles().SingleOrDefault(x => x.Name == Profile);
            if (profile == null)
            {
                Console.Error.WriteLine($"Could not resolve profile] for name [{Profile}]");
                return -1;
            }

            var options = _serializer.Load(profile);
            var jso = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                IncludeFields = false,
                WriteIndented = true,
            };
            Console.Out.Write(JsonSerializer.Serialize(options, jso));
            return 0;
        }
    }
}
