using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'SalesTerritory'
    /// </summary>
    public partial class SalesTerritory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesTerritory"/> class.
        /// </summary>
        public SalesTerritory()
        {
            #region Generated Constructor

            Customers = new HashSet<Customer>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            SalesPeople = new HashSet<SalesPerson>();
            SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
            StateProvinces = new HashSet<StateProvince>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'TerritoryID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TerritoryID'.
        /// </value>
        public int TerritoryID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CountryRegionCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CountryRegionCode'.
        /// </value>
        public string CountryRegionCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Group'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Group'.
        /// </value>
        public string Group { get; set; }

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
        /// Gets or sets the property value representing column 'CostYTD'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CostYTD'.
        /// </value>
        public decimal CostYTD { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CostLastYear'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CostLastYear'.
        /// </value>
        public decimal CostLastYear { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="CountryRegion" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="CountryRegion" />.
        /// </value>
        /// <seealso cref="CountryRegionCode" />
        public virtual CountryRegion CountryRegion {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="Customer" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="Customer" />.
        /// </value>
        public virtual ICollection<Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </value>
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesPerson" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesPerson" />.
        /// </value>
        public virtual ICollection<SalesPerson> SalesPeople { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesTerritoryHistory" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesTerritoryHistory" />.
        /// </value>
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="StateProvince" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="StateProvince" />.
        /// </value>
        public virtual ICollection<StateProvince> StateProvinces { get; set; }

        #endregion // Generated Relationships
    }
}
