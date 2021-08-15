using System;
using System.Collections.Generic;

namespace AdvWorksLT.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'SalesOrderDetail'
    /// </summary>
    public partial class SalesOrderDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderDetail"/> class.
        /// </summary>
        public SalesOrderDetail()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'SalesOrderID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesOrderID'.
        /// </value>
        public int SalesOrderID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalesOrderDetailID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesOrderDetailID'.
        /// </value>
        public int SalesOrderDetailID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OrderQty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OrderQty'.
        /// </value>
        public short OrderQty { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductID'.
        /// </value>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UnitPrice'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UnitPrice'.
        /// </value>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UnitPriceDiscount'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UnitPriceDiscount'.
        /// </value>
        public decimal UnitPriceDiscount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LineTotal'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LineTotal'.
        /// </value>
        public decimal LineTotal { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Product" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Product" />.
        /// </value>
        /// <seealso cref="ProductID" />
        public virtual Product Product {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="SalesOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="SalesOrderHeader" />.
        /// </value>
        /// <seealso cref="SalesOrderID" />
        public virtual SalesOrderHeader SalesOrderHeader {get; set; }
        
        #endregion // Generated Relationships
    }
}
