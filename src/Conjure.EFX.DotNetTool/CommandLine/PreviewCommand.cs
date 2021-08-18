using System.Linq;
using McMaster.Extensions.CommandLineUtils;

namespace Conjure.EFX.DotNetTool.CommandLine
{
    public class PreviewCommand : BaseCommand
    {
        private IProfileOptionsSerializer _serializer;
        private IModelCacheBuilder _cacheBuilder;
        private ICodeGenerator _codeGenerator;

        public PreviewCommand(IProfileOptionsSerializer serializer, IModelCacheBuilder cacheBuilder,
            ICodeGenerator codeGenerator)
        {
            _serializer = serializer;
            _cacheBuilder = cacheBuilder;
            _codeGenerator = codeGenerator;
        }

        [Argument(0, Description = "name of the profile to for which to preview generated code")]
        public string Profile { get; set; }

        public void OnExecute()
        {
            if (Profile == null)
            {
                throw new Exception("You must specify a profile name to preivew");
            }

            var profile = GetProfiles().SingleOrDefault(x => x.Name == Profile);
            if (profile == null)
            {
                throw new Exception($"Could not resolve profile] for name [{Profile}]");
            }

            var options = _serializer.Load(profile);
            Console.WriteLine("Got Options: " + options);

            var model = _cacheBuilder.LoadFromCache(options);
            _codeGenerator.Generate(options, model, File.WriteAllText);
        }
    }
}