using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Currency'
    /// </summary>
    public partial class Currency
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Currency"/> class.
        /// </summary>
        public Currency()
        {
            #region Generated Constructor

            CountryRegionCurrencies = new HashSet<CountryRegionCurrency>();
            FromCurrencyRates = new HashSet<CurrencyRate>();
            ToCurrencyRates = new HashSet<CurrencyRate>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'CurrencyCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CurrencyCode'.
        /// </value>
        public string CurrencyCode { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="CurrencyRate" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="CurrencyRate" />.
        /// </value>
        public virtual ICollection<CurrencyRate> FromCurrencyRates { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="CurrencyRate" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="CurrencyRate" />.
        /// </value>
        public virtual ICollection<CurrencyRate> ToCurrencyRates { get; set; }

        #endregion // Generated Relationships
    }
}
