using Conjure.EFX.Impl;
using Conjure.EFX.Options;
using McMaster.Extensions.CommandLineUtils;

namespace Conjure.EFX.DotNetTool.CommandLine
{
    [Command(names: new[] { "generate", "gen" },
        Description = "generate code from a Profile's options and resolved templates")]
    public class GenerateCommand : BaseCommand
    {
        private readonly IProfileOptionsSerializer _serializer;
        private readonly IModelCacheBuilder _cacheBuilder;
        private readonly ICodeGenerator _codeGenerator;

        public GenerateCommand(IProfileOptionsSerializer serializer, IModelCacheBuilder cacheBuilder,
            ICodeGenerator codeGenerator)
        {
            _serializer = serializer;
            _cacheBuilder = cacheBuilder;
            _codeGenerator = codeGenerator;
        }

        [Argument(0, Description = "name of the profile for which to generate code")]
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
            Console.WriteLine("Got Options: " + options);

            var tc = ResolveTemplates(options);

            var model = _cacheBuilder.LoadFromCache(options);
            _codeGenerator.Generate(options, model, tc, File.WriteAllText);
            return 0;
        }

        public static ITemplatesConfig ResolveTemplates(ProfileOptions options)
        {
            var templatesPath = options.Project.Templates;

            if (string.IsNullOrEmpty(templatesPath))
            {
                templatesPath = "asm://Conjure.EFX.DotNetTool/res.templates.yaml";
            }

            return TemplatesConfig.Load(options, templatesPath,
                options.Options.ProfilePath);
        }
    }
}
