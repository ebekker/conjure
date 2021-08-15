using System;
using System.Collections.Generic;

namespace AdvWorksLT.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'SalesOrderHeader'
    /// </summary>
    public partial class SalesOrderHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderHeader"/> class.
        /// </summary>
        public SalesOrderHeader()
        {
            #region Generated Constructor

            SalesOrderDetails = new HashSet<SalesOrderDetail>();

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
        /// Gets or sets the property value representing column 'RevisionNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RevisionNumber'.
        /// </value>
        public byte RevisionNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OrderDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OrderDate'.
        /// </value>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DueDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DueDate'.
        /// </value>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ShipDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ShipDate'.
        /// </value>
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Status'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Status'.
        /// </value>
        public byte Status { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OnlineOrderFlag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OnlineOrderFlag'.
        /// </value>
        public bool OnlineOrderFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalesOrderNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesOrderNumber'.
        /// </value>
        public string SalesOrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PurchaseOrderNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PurchaseOrderNumber'.
        /// </value>
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AccountNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AccountNumber'.
        /// </value>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CustomerID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CustomerID'.
        /// </value>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ShipToAddressID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ShipToAddressID'.
        /// </value>
        public int? ShipToAddressID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BillToAddressID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BillToAddressID'.
        /// </value>
        public int? BillToAddressID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ShipMethod'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ShipMethod'.
        /// </value>
        public string ShipMethod { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreditCardApprovalCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreditCardApprovalCode'.
        /// </value>
        public string CreditCardApprovalCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SubTotal'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SubTotal'.
        /// </value>
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TaxAmt'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TaxAmt'.
        /// </value>
        public decimal TaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Freight'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Freight'.
        /// </value>
        public decimal Freight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TotalDue'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TotalDue'.
        /// </value>
        public decimal TotalDue { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Comment'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Comment'.
        /// </value>
        public string Comment { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Address" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Address" />.
        /// </value>
        /// <seealso cref="BillToAddressID" />
        public virtual Address BillToAddress {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Customer" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Customer" />.
        /// </value>
        /// <seealso cref="CustomerID" />
        public virtual Customer Customer {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderDetail" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderDetail" />.
        /// </value>
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Address" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Address" />.
        /// </value>
        /// <seealso cref="ShipToAddressID" />
        public virtual Address ShipToAddress {get; set; }
        
        #endregion // Generated Relationships
    }
}
