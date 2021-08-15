using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ProductSubcategory'
    /// </summary>
    public partial class ProductSubcategory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubcategory"/> class.
        /// </summary>
        public ProductSubcategory()
        {
            #region Generated Constructor

            Products = new HashSet<Product>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ProductSubcategoryID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductSubcategoryID'.
        /// </value>
        public int ProductSubcategoryID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductCategoryID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductCategoryID'.
        /// </value>
        public int ProductCategoryID { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="ProductCategory" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="ProductCategory" />.
        /// </value>
        /// <seealso cref="ProductCategoryID" />
        public virtual ProductCategory ProductCategory {get; set; }
        
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
