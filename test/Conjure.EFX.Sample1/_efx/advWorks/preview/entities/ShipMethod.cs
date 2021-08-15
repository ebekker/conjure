using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ShipMethod'
    /// </summary>
    public partial class ShipMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipMethod"/> class.
        /// </summary>
        public ShipMethod()
        {
            #region Generated Constructor

            PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ShipMethodID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ShipMethodID'.
        /// </value>
        public int ShipMethodID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ShipBase'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ShipBase'.
        /// </value>
        public decimal ShipBase { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ShipRate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ShipRate'.
        /// </value>
        public decimal ShipRate { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="PurchaseOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="PurchaseOrderHeader" />.
        /// </value>
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </value>
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        #endregion // Generated Relationships
    }
}
