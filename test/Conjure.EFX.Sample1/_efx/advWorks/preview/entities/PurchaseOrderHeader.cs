using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'PurchaseOrderHeader'
    /// </summary>
    public partial class PurchaseOrderHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderHeader"/> class.
        /// </summary>
        public PurchaseOrderHeader()
        {
            #region Generated Constructor

            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();

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
        /// Gets or sets the property value representing column 'RevisionNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RevisionNumber'.
        /// </value>
        public byte RevisionNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Status'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Status'.
        /// </value>
        public byte Status { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EmployeeID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EmployeeID'.
        /// </value>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VendorID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VendorID'.
        /// </value>
        public int VendorID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ShipMethodID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ShipMethodID'.
        /// </value>
        public int ShipMethodID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OrderDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OrderDate'.
        /// </value>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ShipDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ShipDate'.
        /// </value>
        public DateTime? ShipDate { get; set; }

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
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public DateTime ModifiedDate { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Employee" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Employee" />.
        /// </value>
        /// <seealso cref="EmployeeID" />
        public virtual Employee Employee {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="PurchaseOrderDetail" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="PurchaseOrderDetail" />.
        /// </value>
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="ShipMethod" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="ShipMethod" />.
        /// </value>
        /// <seealso cref="ShipMethodID" />
        public virtual ShipMethod ShipMethod {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Vendor" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Vendor" />.
        /// </value>
        /// <seealso cref="VendorID" />
        public virtual Vendor Vendor {get; set; }
        
        #endregion // Generated Relationships
    }
}
