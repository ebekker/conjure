﻿using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace Conjure.EFX.Options
{
    /// <summary>
    /// EntityFramework <see cref="DbContext"/> generation options
    /// </summary>
    /// <seealso cref="BaseClassOptions" />
    public class ContextClassOptions : BaseClassOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextClassOptions"/> class.
        /// </summary>
        public ContextClassOptions(VariableDictionary variables, string prefix)
            : base(variables, AppendPrefix(prefix, "Context"))
        {
            Namespace = "{Project.Namespace}.Data";
            Directory = @"{Project.Directory}\Data";

            Name = "{Database.Name}Context";
            BaseClass = "DbContext";
            PropertyNaming = ContextNaming.Plural;
        }

        /// <summary>
        /// Gets or sets the class name for the generated <see cref="DbContext"/> file.
        /// </summary>
        /// <value>
        /// The class name for the <see cref="DbContext"/> file.
        /// </value>
        public string Name
        {
            get => GetProperty();
            set => SetProperty(value);
        }

        /// <summary>
        /// Gets or sets the base class to inherit from. Default is <see cref="DbContext"/>.
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
        /// Gets or sets the property naming strategy for entity data set property.
        /// </summary>
        /// <value>
        /// The property naming strategy for entity data set property.
        /// </value>
        [DefaultValue(ContextNaming.Plural)]
        public ContextNaming PropertyNaming { get; set; }
    }
}