using System;
using System.Collections.Generic;

namespace AdvWorksLT.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ProductCategory'
    /// </summary>
    public partial class ProductCategory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCategory"/> class.
        /// </summary>
        public ProductCategory()
        {
            #region Generated Constructor

            ParentProductCategories = new HashSet<ProductCategory>();
            Products = new HashSet<Product>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ProductCategoryID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductCategoryID'.
        /// </value>
        public int ProductCategoryID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ParentProductCategoryID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ParentProductCategoryID'.
        /// </value>
        public int? ParentProductCategoryID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="ProductCategory" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductCategory" />.
        /// </value>
        public virtual ICollection<ProductCategory> ParentProductCategories { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="ProductCategory" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="ProductCategory" />.
        /// </value>
        /// <seealso cref="ParentProductCategoryID" />
        public virtual ProductCategory ParentProductCategory {get; set; }
        
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
