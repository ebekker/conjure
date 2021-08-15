using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'PurchaseOrderDetail'
    /// </summary>
    public partial class PurchaseOrderDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderDetail"/> class.
        /// </summary>
        public PurchaseOrderDetail()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'PurchaseOrderID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PurchaseOrderID'.
        /// </value>
        public int PurchaseOrderID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PurchaseOrderDetailID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PurchaseOrderDetailID'.
        /// </value>
        public int PurchaseOrderDetailID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DueDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DueDate'.
        /// </value>
        public DateTime DueDate { get; set; }

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
        /// Gets or sets the property value representing column 'LineTotal'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LineTotal'.
        /// </value>
        public decimal LineTotal { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ReceivedQty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ReceivedQty'.
        /// </value>
        public decimal ReceivedQty { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RejectedQty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RejectedQty'.
        /// </value>
        public decimal RejectedQty { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'StockedQty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StockedQty'.
        /// </value>
        public decimal StockedQty { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="PurchaseOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="PurchaseOrderHeader" />.
        /// </value>
        /// <seealso cref="PurchaseOrderID" />
        public virtual PurchaseOrderHeader PurchaseOrderHeader {get; set; }
        
        #endregion // Generated Relationships
    }
}
