using McMaster.Extensions.CommandLineUtils;

namespace Conjure.EFX.DotNetTool.CommandLine
{
    [Command(Description = "list all the detected Profiles")]
    public class ListCommand : BaseCommand
    {
        [Option]
        public bool Detailed { get; set; }

        // public async Task OnExecuteAsync()
        public void OnExecute()
        {
            if (Detailed)
            {
                Console.WriteLine($"{Project}:");
                foreach (var profile in GetProfiles())
                {
                    Console.WriteLine($"  * Profile: {profile.Name}");
                    Console.WriteLine($"    - Profile Path:  {profile.ProfilePath}");
                    Console.WriteLine($"    - Options Path:  {profile.OptionsPath}");
                }
            }
            else
            {
                foreach (var profile in GetProfiles())
                {
                    Console.WriteLine(profile.Name);
                }
            }
        }
    }
}
