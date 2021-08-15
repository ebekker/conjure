using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Customer'
    /// </summary>
    public partial class Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
        {
            #region Generated Constructor

            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'CustomerID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CustomerID'.
        /// </value>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PersonID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PersonID'.
        /// </value>
        public int? PersonID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'StoreID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StoreID'.
        /// </value>
        public int? StoreID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TerritoryID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TerritoryID'.
        /// </value>
        public int? TerritoryID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AccountNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AccountNumber'.
        /// </value>
        public string AccountNumber { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Person" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Person" />.
        /// </value>
        /// <seealso cref="PersonID" />
        public virtual Person Person {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </value>
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="SalesTerritory" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="SalesTerritory" />.
        /// </value>
        /// <seealso cref="TerritoryID" />
        public virtual SalesTerritory SalesTerritory {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Store" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Store" />.
        /// </value>
        /// <seealso cref="StoreID" />
        public virtual Store Store {get; set; }
        
        #endregion // Generated Relationships
    }
}
