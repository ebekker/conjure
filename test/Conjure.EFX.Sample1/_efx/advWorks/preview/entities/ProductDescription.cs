using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ProductDescription'
    /// </summary>
    public partial class ProductDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDescription"/> class.
        /// </summary>
        public ProductDescription()
        {
            #region Generated Constructor

            ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ProductDescriptionID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductDescriptionID'.
        /// </value>
        public int ProductDescriptionID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Description'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Description'.
        /// </value>
        public string Description { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="ProductModelProductDescriptionCulture" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductModelProductDescriptionCulture" />.
        /// </value>
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

        #endregion // Generated Relationships
    }
}
