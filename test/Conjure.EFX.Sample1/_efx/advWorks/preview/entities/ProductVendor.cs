using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ProductVendor'
    /// </summary>
    public partial class ProductVendor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVendor"/> class.
        /// </summary>
        public ProductVendor()
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
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BusinessEntityID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BusinessEntityID'.
        /// </value>
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AverageLeadTime'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AverageLeadTime'.
        /// </value>
        public int AverageLeadTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'StandardPrice'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StandardPrice'.
        /// </value>
        public decimal StandardPrice { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LastReceiptCost'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LastReceiptCost'.
        /// </value>
        public decimal? LastReceiptCost { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LastReceiptDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LastReceiptDate'.
        /// </value>
        public DateTime? LastReceiptDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MinOrderQty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MinOrderQty'.
        /// </value>
        public int MinOrderQty { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MaxOrderQty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MaxOrderQty'.
        /// </value>
        public int MaxOrderQty { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OnOrderQty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OnOrderQty'.
        /// </value>
        public int? OnOrderQty { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UnitMeasureCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UnitMeasureCode'.
        /// </value>
        public string UnitMeasureCode { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Product" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Product" />.
        /// </value>
        /// <seealso cref="ProductID" />
        public virtual Product Product {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="UnitMeasure" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="UnitMeasure" />.
        /// </value>
        /// <seealso cref="UnitMeasureCode" />
        public virtual UnitMeasure UnitMeasure {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Vendor" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Vendor" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual Vendor Vendor {get; set; }
        
        #endregion // Generated Relationships
    }
}
