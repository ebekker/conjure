using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'SalesPerson'
    /// </summary>
    public partial class SalesPerson
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesPerson"/> class.
        /// </summary>
        public SalesPerson()
        {
            #region Generated Constructor

            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            SalesPersonQuotaHistories = new HashSet<SalesPersonQuotaHistory>();
            SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
            Stores = new HashSet<Store>();

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
        /// Gets or sets the property value representing column 'TerritoryID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TerritoryID'.
        /// </value>
        public int? TerritoryID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalesQuota'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesQuota'.
        /// </value>
        public decimal? SalesQuota { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Bonus'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Bonus'.
        /// </value>
        public decimal Bonus { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CommissionPct'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CommissionPct'.
        /// </value>
        public decimal CommissionPct { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalesYTD'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesYTD'.
        /// </value>
        public decimal SalesYTD { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalesLastYear'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesLastYear'.
        /// </value>
        public decimal SalesLastYear { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Employee" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Employee" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual Employee Employee {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </value>
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesPersonQuotaHistory" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesPersonQuotaHistory" />.
        /// </value>
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="SalesTerritory" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="SalesTerritory" />.
        /// </value>
        /// <seealso cref="TerritoryID" />
        public virtual SalesTerritory SalesTerritory {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesTerritoryHistory" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesTerritoryHistory" />.
        /// </value>
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="Store" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="Store" />.
        /// </value>
        public virtual ICollection<Store> Stores { get; set; }

        #endregion // Generated Relationships
    }
}
