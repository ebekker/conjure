using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'CountryRegion'
    /// </summary>
    public partial class CountryRegion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryRegion"/> class.
        /// </summary>
        public CountryRegion()
        {
            #region Generated Constructor

            CountryRegionCurrencies = new HashSet<CountryRegionCurrency>();
            SalesTerritories = new HashSet<SalesTerritory>();
            StateProvinces = new HashSet<StateProvince>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'CountryRegionCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CountryRegionCode'.
        /// </value>
        public string CountryRegionCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="CountryRegionCurrency" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="CountryRegionCurrency" />.
        /// </value>
        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesTerritory" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesTerritory" />.
        /// </value>
        public virtual ICollection<SalesTerritory> SalesTerritories { get; set; }

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
