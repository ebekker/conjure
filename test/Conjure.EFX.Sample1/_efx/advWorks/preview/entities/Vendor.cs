using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Vendor'
    /// </summary>
    public partial class Vendor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vendor"/> class.
        /// </summary>
        public Vendor()
        {
            #region Generated Constructor

            ProductVendors = new HashSet<ProductVendor>();
            PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'BusinessEntityID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BusinessEntityID'.
        /// </value>
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AccountNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AccountNumber'.
        /// </value>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreditRating'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreditRating'.
        /// </value>
        public byte CreditRating { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PreferredVendorStatus'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PreferredVendorStatus'.
        /// </value>
        public bool PreferredVendorStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ActiveFlag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ActiveFlag'.
        /// </value>
        public bool ActiveFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PurchasingWebServiceURL'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PurchasingWebServiceURL'.
        /// </value>
        public string PurchasingWebServiceURL { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="BusinessEntity" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="BusinessEntity" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual BusinessEntity BusinessEntity {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="ProductVendor" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductVendor" />.
        /// </value>
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="PurchaseOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="PurchaseOrderHeader" />.
        /// </value>
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

        #endregion // Generated Relationships
    }
}
