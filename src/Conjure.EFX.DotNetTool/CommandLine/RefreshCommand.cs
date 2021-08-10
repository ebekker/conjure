using System.Linq;
using McMaster.Extensions.CommandLineUtils;

namespace Conjure.EFX.DotNetTool.CommandLine
{
    public class RefreshCommand : BaseCommand
    {
        private IProfileOptionsSerializer _serializer;
        private IModelCacheBuilder _cacheBuilder;

        public RefreshCommand(IProfileOptionsSerializer serializer, IModelCacheBuilder cacheBuilder)
        {
            _serializer = serializer;
            _cacheBuilder = cacheBuilder;
        }

        [Argument(0, Description = "name of the profile to refresh")]
        public string Profile { get; set; }

        public void OnExecute()
        {
            if (Profile == null)
            {
                throw new Exception("You must specify a profile name to refresh");
            }

            var profile = GetProfiles().SingleOrDefault(x => x.Name == Profile);
            if (profile == null)
            {
                throw new Exception($"Could not resolve profile] for name [{Profile}]");
            }

            var options = _serializer.Load(profile);
            Console.WriteLine("Got Options: " + options);

            _cacheBuilder.RefreshCache(options);
        }
    }
}
