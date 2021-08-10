﻿using System.Collections.Generic;

namespace Conjure.EFX.Options
{
    /// <summary>
    /// Script Template options
    /// </summary>
    public class TemplateOptions : BaseOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateOptions"/> class.
        /// </summary>
        /// <param name="variables">The shared variables dictionary.</param>
        /// <param name="prefix">The variable key prefix.</param>
        public TemplateOptions(VariableDictionary variables, string prefix) 
            : base(variables, AppendPrefix(prefix, "Template"))
        {
            Parameters = new Dictionary<string, string>();
        }

        /// <summary>
        /// Gets or sets the template file path.
        /// </summary>
        /// <value>
        /// The template file path.
        /// </value>
        public string TemplatePath
        {
            get => GetProperty();
            set => SetProperty(value);
        }
        
        /// <summary>
        /// Gets or sets the name of the class
        /// </summary>
        /// <value>
        /// The name of the class.
        /// </value>
        public string FileName
        {
            get => GetProperty();
            set => SetProperty(value);
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
        /// Gets or sets the base class.
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
        /// Gets or sets a value indicating whether the generated file will be over written.
        /// </summary>
        /// <value>
        ///   <c>true</c> to overwrite generated file; otherwise, <c>false</c>.
        /// </value>
        public bool Overwrite { get; set; }

        /// <summary>
        /// Gets or sets the template parameters.
        /// </summary>
        /// <value>
        /// The template parameters.
        /// </value>
        public Dictionary<string, string> Parameters { get; set; }
    }
}