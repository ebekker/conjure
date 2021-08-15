using System;
using System.Collections.Generic;

namespace AdvWorksLT.Data.Entities
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
        public int ProductModelID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductDescriptionID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductDescriptionID'.
        /// </value>
        public int ProductDescriptionID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Culture'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Culture'.
        /// </value>
        public string Culture { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'rowguid'.
        /// </summary>
        /// <value>
        /// The property value representing column 'rowguid'.
        /// </value>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public DateTime ModifiedDate { get; set; }

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
