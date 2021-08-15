using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ProductModel'
    /// </summary>
    public partial class ProductModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModel"/> class.
        /// </summary>
        public ProductModel()
        {
            #region Generated Constructor

            ProductModelIllustrations = new HashSet<ProductModelIllustration>();
            ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
            Products = new HashSet<Product>();

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
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CatalogDescription'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CatalogDescription'.
        /// </value>
        public string CatalogDescription { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Instructions'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Instructions'.
        /// </value>
        public string Instructions { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="ProductModelIllustration" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductModelIllustration" />.
        /// </value>
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="ProductModelProductDescriptionCulture" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductModelProductDescriptionCulture" />.
        /// </value>
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="Product" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="Product" />.
        /// </value>
        public virtual ICollection<Product> Products { get; set; }

        #endregion // Generated Relationships
    }
}
