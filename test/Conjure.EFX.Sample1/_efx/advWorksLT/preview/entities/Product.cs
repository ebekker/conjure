using System;
using System.Collections.Generic;

namespace AdvWorksLT.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Product'
    /// </summary>
    public partial class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product()
        {
            #region Generated Constructor

            SalesOrderDetails = new HashSet<SalesOrderDetail>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ProductID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductID'.
        /// </value>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductNumber'.
        /// </value>
        public string ProductNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Color'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Color'.
        /// </value>
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'StandardCost'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StandardCost'.
        /// </value>
        public decimal StandardCost { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ListPrice'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ListPrice'.
        /// </value>
        public decimal ListPrice { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Size'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Size'.
        /// </value>
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Weight'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Weight'.
        /// </value>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductCategoryID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductCategoryID'.
        /// </value>
        public int? ProductCategoryID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductModelID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductModelID'.
        /// </value>
        public int? ProductModelID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SellStartDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SellStartDate'.
        /// </value>
        public DateTime SellStartDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SellEndDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SellEndDate'.
        /// </value>
        public DateTime? SellEndDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DiscontinuedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DiscontinuedDate'.
        /// </value>
        public DateTime? DiscontinuedDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ThumbNailPhoto'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ThumbNailPhoto'.
        /// </value>
        public Byte[] ThumbNailPhoto { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ThumbnailPhotoFileName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ThumbnailPhotoFileName'.
        /// </value>
        public string ThumbnailPhotoFileName { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="ProductModel" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="ProductModel" />.
        /// </value>
        /// <seealso cref="ProductModelID" />
        public virtual ProductModel ProductModel {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderDetail" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderDetail" />.
        /// </value>
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

        #endregion // Generated Relationships
    }
}
