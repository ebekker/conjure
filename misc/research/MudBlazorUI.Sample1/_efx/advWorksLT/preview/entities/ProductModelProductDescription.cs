#pragma warning disable IDE0073 // The file header is missing or not located at the top of the file
/** THIS IS AUTOGENERATED BY CONJURE EFX **/
#pragma warning restore IDE0073 // The file header is missing or not located at the top of the file

using System;
using System.Collections.Generic;

namespace ConjureApp.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ProductModelProductDescription'
    /// </summary>
    public partial class ProductModelProductDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModelProductDescription"/> class.
        /// </summary>
        public ProductModelProductDescription()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ProductModelID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductModelID'.
        /// </value>
        public virtual int ProductModelID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductDescriptionID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductDescriptionID'.
        /// </value>
        public virtual int ProductDescriptionID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Culture'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Culture'.
        /// </value>
        public virtual string Culture { get; set; } = default!;

        /// <summary>
        /// Gets or sets the property value representing column 'rowguid'.
        /// </summary>
        /// <value>
        /// The property value representing column 'rowguid'.
        /// </value>
        public virtual Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public virtual DateTime ModifiedDate { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="ProductDescription" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="ProductDescription" />.
        /// </value>
        /// <seealso cref="ProductDescriptionID" />
        public virtual ProductDescription ProductDescription {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="ProductModel" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="ProductModel" />.
        /// </value>
        /// <seealso cref="ProductModelID" />
        public virtual ProductModel ProductModel {get; set; }
        
        #endregion // Generated Relationships
    }
}
