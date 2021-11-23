// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.EFX;

public class ProfileInfo
{
    public const string DefaultProfileDirectoryExtension = ".efx";
    public const string DefaultProfileOptionsFileName = "_efx.yaml";
    public const string DefaultRootOutputRootDirectory = "_efx";
    public const string DefaultSharedOutputDirectory = "_efx/shared";
    public const string DefaultProfileOutputDirectory = "_efx/profiles/{0}";

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

    public string SharedOutputPath { get; init; }
    public string ProfileOutputPath { get; init; }

    public static IEnumerable<ProfileInfo> GetProfiles(string path = null)
    {
        if (path == null)
            path = Directory.GetCurrentDirectory();

        var profileDirs = Directory.GetDirectories(path, "*" + DefaultProfileDirectoryExtension);

        var sharedOutputDirectory = Path.Combine(path, DefaultSharedOutputDirectory);

        foreach (var cd in profileDirs)
        {
            var profileName = Path.GetFileNameWithoutExtension(cd);

            var profileFile = Path.Combine(cd, DefaultProfileOptionsFileName);
            var profileOutputDirectory = Path.Combine(path,
                string.Format(DefaultProfileOutputDirectory, profileName));

            if (!File.Exists(profileFile))
                continue;

            yield return new ProfileInfo
            {
                Name = profileName,
                ProfilePath = cd,
                OptionsPath = profileFile,

                SharedOutputPath = sharedOutputDirectory,
                ProfileOutputPath = profileOutputDirectory,
            };
        }
    }
}
