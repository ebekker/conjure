using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'StateProvince'
    /// </summary>
    public partial class StateProvince
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateProvince"/> class.
        /// </summary>
        public StateProvince()
        {
            #region Generated Constructor

            Addresses = new HashSet<Address>();
            SalesTaxRates = new HashSet<SalesTaxRate>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'StateProvinceID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StateProvinceID'.
        /// </value>
        public int StateProvinceID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'StateProvinceCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StateProvinceCode'.
        /// </value>
        public string StateProvinceCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CountryRegionCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CountryRegionCode'.
        /// </value>
        public string CountryRegionCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IsOnlyStateProvinceFlag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IsOnlyStateProvinceFlag'.
        /// </value>
        public bool IsOnlyStateProvinceFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TerritoryID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TerritoryID'.
        /// </value>
        public int TerritoryID { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="Address" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="Address" />.
        /// </value>
        public virtual ICollection<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="CountryRegion" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="CountryRegion" />.
        /// </value>
        /// <seealso cref="CountryRegionCode" />
        public virtual CountryRegion CountryRegion {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesTaxRate" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesTaxRate" />.
        /// </value>
        public virtual ICollection<SalesTaxRate> SalesTaxRates { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="SalesTerritory" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="SalesTerritory" />.
        /// </value>
        /// <seealso cref="TerritoryID" />
        public virtual SalesTerritory SalesTerritory {get; set; }
        
        #endregion // Generated Relationships
    }
}
