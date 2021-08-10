using System.ComponentModel;

namespace Conjure.EFX.Options
{
    /// <summary>
    /// Base class for Class generation
    /// </summary>
    public abstract class BaseClassOptions : BaseOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseClassOptions"/> class.
        /// </summary>
        protected BaseClassOptions(VariableDictionary variables, string prefix)
            : base(variables, prefix)
        {
            Namespace = "{Project.Namespace}";
            Directory = @"{Project.Directory}\";
            Document = false;
        }

        /// <summary>
        /// Gets or sets the class namespace.
        /// </summary>
        /// <value>
        /// The class namespace.
        /// </value>
        public string Namespace
        {
            get => GetProperty();
            set => SetProperty(value);
        }

        /// <summary>
        /// Gets or sets the output directory.  Default is the current working directory.
        /// </summary>
        /// <value>
        /// The output directory.
        /// </value>
        public string Directory
        {
            get => GetProperty();
            set => SetProperty(value);
        }

        /// <summary>
        /// Gets or sets a value indicating whether to create xml documentation.
        /// </summary>
        /// <value>
        ///   <c>true</c> to create xml documentation; otherwise, <c>false</c>.
        /// </value>
        [DefaultValue(false)]
        public bool Document { get; set; }
    }
}