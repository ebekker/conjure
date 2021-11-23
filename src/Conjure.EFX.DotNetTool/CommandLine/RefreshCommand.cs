using McMaster.Extensions.CommandLineUtils;

namespace Conjure.EFX.DotNetTool.CommandLine
{
    [Command(Description = "refresh the local cache of the Profile's data model from the target DB")]
    public class RefreshCommand : BaseCommand
    {
        private readonly IProfileOptionsSerializer _serializer;
        private readonly IModelCacheBuilder _cacheBuilder;

        public RefreshCommand(IProfileOptionsSerializer serializer, IModelCacheBuilder cacheBuilder)
        {
            _serializer = serializer;
            _cacheBuilder = cacheBuilder;
        }

        [Argument(0, Description = "name of the profile to refresh")]
        public string Profile { get; set; }

        public int OnExecute()
        {
            if (Profile == null)
            {
                Console.Error.WriteLine("You must specify a profile name to refresh");
                return -1;
            }

            var profile = GetProfiles().SingleOrDefault(x => x.Name == Profile);
            if (profile == null)
            {
                Console.Error.WriteLine($"Could not resolve profile] for name [{Profile}]");
                return -1;
            }

            var options = _serializer.Load(profile);
            Console.WriteLine("Got Options: " + options);

            _cacheBuilder.RefreshCache(options);
            return 0;
        }
    }
}
