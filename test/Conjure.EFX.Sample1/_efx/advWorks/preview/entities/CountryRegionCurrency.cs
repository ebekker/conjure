using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'CountryRegionCurrency'
    /// </summary>
    public partial class CountryRegionCurrency
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryRegionCurrency"/> class.
        /// </summary>
        public CountryRegionCurrency()
        {
            #region Generated Constructor


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
        /// Gets or sets the property value representing column 'CurrencyCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CurrencyCode'.
        /// </value>
        public string CurrencyCode { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Currency" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Currency" />.
        /// </value>
        /// <seealso cref="CurrencyCode" />
        public virtual Currency Currency {get; set; }
        
        #endregion // Generated Relationships
    }
}
