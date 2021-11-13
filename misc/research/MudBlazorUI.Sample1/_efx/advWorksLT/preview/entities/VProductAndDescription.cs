#pragma warning disable IDE0073 // The file header is missing or not located at the top of the file
/** THIS IS AUTOGENERATED BY CONJURE EFX **/
#pragma warning restore IDE0073 // The file header is missing or not located at the top of the file

using System;
using System.Collections.Generic;

namespace ConjureApp.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'vProductAndDescription'
    /// </summary>
    public partial class VProductAndDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VProductAndDescription"/> class.
        /// </summary>
        public VProductAndDescription()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ProductID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductID'.
        /// </value>
        public virtual int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public virtual string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the property value representing column 'ProductModel'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductModel'.
        /// </value>
        public virtual string ProductModel { get; set; } = default!;

        /// <summary>
        /// Gets or sets the property value representing column 'Culture'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Culture'.
        /// </value>
        public virtual string Culture { get; set; } = default!;

        /// <summary>
        /// Gets or sets the property value representing column 'Description'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Description'.
        /// </value>
        public virtual string Description { get; set; } = default!;

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}
