namespace Conjure.EFX.DotNetTool.CommandLine
{
    public class ListCommand : BaseCommand
    {
        // public async Task OnExecuteAsync()
        public void OnExecute()
        {
            Console.WriteLine($"{Project}:");
            foreach (var profile in GetProfiles())
            {
                Console.WriteLine($"  * {profile.Name}");
                Console.WriteLine($"    - {profile.ProfilePath}");
                Console.WriteLine($"    - {profile.OptionsPath}");
            }
        }
    }
}