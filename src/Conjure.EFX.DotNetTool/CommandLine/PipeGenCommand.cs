using System.IO.Pipes;
using System.Text;
using Conjure.PipeTalk;
using McMaster.Extensions.CommandLineUtils;

namespace Conjure.EFX.DotNetTool.CommandLine
{
    [Command(ShowInHelpText = false)]
    public class PipeGenCommand : BaseCommand
    {
        private IProfileOptionsSerializer _serializer;
        private IModelCacheBuilder _cacheBuilder;
        private ICodeGenerator _codeGenerator;

        public PipeGenCommand(IProfileOptionsSerializer serializer, IModelCacheBuilder cacheBuilder,
            ICodeGenerator codeGenerator)
        {
            _serializer = serializer;
            _cacheBuilder = cacheBuilder;
            _codeGenerator = codeGenerator;
        }

        [Option("--pipe-name")]
        public string PipeName { get; set; }

        public void OnExecute()
        {
            using var server = OutProcGenProtocol.CreateServer(PipeName);
            server.WaitForConnection();
            server.BeginSession();

            //           server.StartProfile("all_profiles");

            //           var buff = new StringBuilder();
            //           buff.AppendLine(@"
            //namespace Conjure.Gen
            //{
            //    public partial class Profiles
            //    {
            //");
            //           foreach (var profile in GetProfiles())
            //           {
            //               buff.AppendLine($"        // {profile.Name}");
            //               buff.AppendLine($"        public const string ProfilePath_{profile.Name} = \"{profile.ProfilePath.Replace("\\", "\\\\")}\";");
            //               buff.AppendLine($"        public const string OptionsPath_{profile.Name} = \"{profile.OptionsPath.Replace("\\", "\\\\")}\";");
            //           }
            //           buff.AppendLine(@"
            //    }
            //}
            //");
            //           server.AddFile("AllProfiles.cs", buff.ToString());

            try
            {
                foreach (var profile in GetProfiles())
                {
                    var options = _serializer.Load(profile);
                    var model = _cacheBuilder.LoadFromCache(options);

                    server.StartProfile(profile.Name);
                    _codeGenerator.Generate(options, model, server.AddFile);
                }
            }
            catch (Exception ex)
            {
                server.Fail("???", ex.Message, ex.StackTrace);
            }

            server.EndSession();
        }
    }
}