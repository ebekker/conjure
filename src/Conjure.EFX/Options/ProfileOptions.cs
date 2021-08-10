using System;
using YamlDotNet.Serialization;

namespace Conjure.EFX.Options
{
    /// <summary>
    /// Top level generator configuration options
    /// </summary>
    public class ProfileOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileOptions"/> class.
        /// </summary>
        public ProfileOptions(ProfileInfo profile)
        {
            Variables = new VariableDictionary();

            Options = new OptionsOptions(profile, Variables, null);

            Project = new ProjectOptions(Variables, null);
            Database = new DatabaseOptions(Variables, null);
            Data = new DataOptions(Variables, null);
            Model = new ModelOptions(Variables, null);
            Script = new ScriptOptions(Variables, null);
        }

        [YamlIgnore]
        public VariableDictionary Variables { get; }

        // [YamlIgnore]
        // public Templates.CodeTemplateWriter CodeWriter { get; set; }

        /// <summary>
        /// Gets the options file meta data.
        /// </summary>
        /// <value>
        /// The optiosn file meta data.
        /// </value>
        public OptionsOptions Options { get; }

        /// <summary>
        /// Gets or sets the project options.
        /// </summary>
        /// <value>
        /// The project level options.
        /// </value>
        public ProjectOptions Project { get; set; }

        /// <summary>
        /// Gets or sets the options for reverse engineer the database.
        /// </summary>
        /// <value>
        /// The database.
        /// </value>
        public DatabaseOptions Database { get; set; }

        /// <summary>
        /// Gets or sets the EntityFramework configuration options.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public DataOptions Data { get; set; }

        /// <summary>
        /// Gets or sets the domain view model options.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public ModelOptions Model { get; set; }

        /// <summary>
        /// Gets or sets the script template options.
        /// </summary>
        /// <value>
        /// The script template options.
        /// </value>
        public ScriptOptions Script { get; set; }
    }
}