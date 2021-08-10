using System;

namespace Conjure.EFX.Options
{
    /// <summary>
    /// Base class for the Model generation
    /// </summary>
    /// <seealso cref="BaseClassOptions" />
    public abstract class BaseModelOptions : BaseClassOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModelOptions"/> class.
        /// </summary>
        protected BaseModelOptions(VariableDictionary variables, string prefix)
            : base(variables, prefix)
        {
            // null so shared option is used
            Namespace = null;
            Directory = null;

            Generate = false;

            Include = new SelectionOptions();
            Exclude = new SelectionOptions();
        }

        /// <summary>
        /// Gets or sets a value indicating whether this option is generated.
        /// </summary>
        /// <value>
        ///   <c>true</c> to generate; otherwise, <c>false</c>.
        /// </value>
        public bool Generate { get; set; }

        /// <summary>
        /// Gets or sets the class name template.
        /// </summary>
        /// <value>
        /// The class name template.
        /// </value>
        public string Name
        {
            get => GetProperty();
            set => SetProperty(value);
        }

        /// <summary>
        /// Gets or sets the base class to inherit from.
        /// </summary>
        /// <value>
        /// The base class.
        /// </value>
        public string BaseClass
        {
            get => GetProperty();
            set => SetProperty(value);
        }


        /// <summary>
        /// Gets or sets the include selection options.
        /// </summary>
        /// <value>
        /// The include selection options.
        /// </value>
        public SelectionOptions Include { get; set; }

        /// <summary>
        /// Gets or sets the exclude selection options.
        /// </summary>
        /// <value>
        /// The exclude selection options.
        /// </value>
        public SelectionOptions Exclude { get; set; }
    }
}