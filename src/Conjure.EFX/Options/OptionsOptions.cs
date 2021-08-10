using System;
using System.IO;

namespace Conjure.EFX.Options
{
    /// <summary>
    /// Options file meta data.
    /// </summary>
    public class OptionsOptions : BaseOptions
    {
        private ProfileInfo _profile;

        public OptionsOptions(ProfileInfo profile, VariableDictionary variables, string prefix)
            : base(variables, AppendPrefix(prefix, "Options"))
        {
            _profile = profile;
            ComputeOptions();
        }

        /// <summary>
        /// Gets just the file name of the current profile.
        /// This value is computed and read-only, and cannot be set.
        /// </summary>
        /// <value>
        /// The file name of the options file.
        /// </value>
        public string ProfileName
        {
            get { return GetProperty(); }
            set { }
        }

        /// <summary>
        /// Gets just the directory containing the current options file.
        /// This value is computed and read-only, and cannot be set.
        /// </summary>
        /// <value>
        /// The directory containing the options file.
        /// </value>
        public string ProfilePath
        {
            get { return GetProperty(); }
            set { }
        }

        /// <summary>
        /// Gets the full path to the current options file.
        /// This value is computed and read-only, and cannot be set.
        /// </summary>
        /// <value>
        /// The full path to the options file.
        /// </value>
        public string FullPath
        {
            get { return GetProperty(); }
            set { }
        }
        
        /// <summary>
        /// Gets the full path to the parent directory containing the profile directory.
        /// This value is computed and read-only, and cannot be set.
        /// </summary>
        /// <value>
        /// The full path to the parent of the profile directory.
        /// </value>
        public string ProfileParentPath
        {
            get { return GetProperty(); }
            set { }
        }

        // /// <summary>
        // /// Gets just the file name without any extension of the current options file.
        // /// This value is computed and read-only, and cannot be set.
        // /// </summary>
        // /// <value>
        // /// The file name without any extension of the options file.
        // /// </value>
        // public string FileNameWithoutExtension
        // {
        //     get { return GetProperty(); }
        //     set { }
        // }

        /// <summary>
        /// Sets the full path to the current options file.
        /// This will also resolve the Directory and File Name.
        /// </summary>
        private void ComputeOptions()
        {
            var name = _profile.Name;
            var profilePath = _profile.ProfilePath;
            var optionsPath = _profile.OptionsPath;

            SetProperty(name, nameof(ProfileName));
            SetProperty(profilePath, nameof(ProfilePath));
            SetProperty(optionsPath, nameof(FullPath));
            SetProperty(Path.GetDirectoryName(profilePath), nameof(ProfileParentPath));

            // // Special handling for *.efg.* sub-extension
            // var filename = Path.GetFileNameWithoutExtension(path);
            // if (filename.EndsWith(".efg", StringComparison.OrdinalIgnoreCase))
            // {
            //     filename = Path.GetFileNameWithoutExtension(filename);
            // }
            // SetProperty(filename, nameof(FileNameWithoutExtension));
        }
    }
}