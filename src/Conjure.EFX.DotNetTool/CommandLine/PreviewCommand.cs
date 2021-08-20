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

        public int OnExecute()
        {
            if (Profile == null)
            {
                Console.Error.WriteLine("You must specify a profile name to preivew");
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

            var model = _cacheBuilder.LoadFromCache(options);
            _codeGenerator.Generate(options, model, File.WriteAllText);
            return 0;
        }
    }
}