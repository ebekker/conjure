#pragma warning disable IDE0073 // The file header is missing or not located at the top of the file
/** THIS IS AUTOGENERATED BY CONJURE EFX **/
#pragma warning restore IDE0073 // The file header is missing or not located at the top of the file

using System;
using System.Collections.Generic;

namespace ConjureApp.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'vGetAllCategories'
    /// </summary>
    public partial class VGetAllCategories
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VGetAllCategories"/> class.
        /// </summary>
        public VGetAllCategories()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ParentProductCategoryName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ParentProductCategoryName'.
        /// </value>
        public virtual string ParentProductCategoryName { get; set; } = default!;

        /// <summary>
        /// Gets or sets the property value representing column 'ProductCategoryName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductCategoryName'.
        /// </value>
        public virtual string? ProductCategoryName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductCategoryID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductCategoryID'.
        /// </value>
        public virtual int? ProductCategoryID { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}
