namespace Conjure.EFX
{
    public class ProfileInfo
    {
        public const string DefaultProfileDirectoryExtension = ".efx";
        public const string DefaultProfileOptionsFileName = "_efx.yaml";

        public string Name { get; init; }

        /// <summary>
        /// Full path to the root directory of a profile.  Within this
        /// directory is the options file and any additional supporting
        /// assets such as templates.
        /// </summary>
        /// <value></value>
        public string ProfilePath { get; init; }

        /// <summary>
        /// Full path to the options file located within a profile directory.
        /// </summary>
        public string OptionsPath { get; init; }

        public static IEnumerable<ProfileInfo> GetProfiles(string path = null)
        {
            if (path == null)
                path = Directory.GetCurrentDirectory();
            
            var profileDirs = Directory.GetDirectories(path, "*" + DefaultProfileDirectoryExtension);

            foreach (var cd in profileDirs)
            {
                var profileFile = Path.Combine(cd, DefaultProfileOptionsFileName);
                if (!File.Exists(profileFile))
                    continue;

                var profileName = Path.GetFileNameWithoutExtension(cd);

                yield return new ProfileInfo
                {
                    Name = profileName,
                    ProfilePath = cd,
                    OptionsPath = profileFile,
                };
            }
        }
    }
}