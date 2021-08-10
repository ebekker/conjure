using McMaster.Extensions.CommandLineUtils;

namespace Conjure.EFX.DotNetTool.CommandLine
{
    public abstract class BaseCommand
    {
        private string _Project;

        [Option(Description = "the base directory in which to search for profile"
            + " sub-directories; defaults to the current folder")]
        public string Project
        {
            get => _Project ?? Directory.GetCurrentDirectory();
            set
            {
                _Project = value;
            }
        }

        protected IEnumerable<ProfileInfo> GetProfiles() => ProfileInfo.GetProfiles(Project);
    }
}