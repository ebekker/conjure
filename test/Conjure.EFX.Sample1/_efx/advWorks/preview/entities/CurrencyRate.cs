using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'CurrencyRate'
    /// </summary>
    public partial class CurrencyRate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyRate"/> class.
        /// </summary>
        public CurrencyRate()
        {
            #region Generated Constructor

            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'CurrencyRateID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CurrencyRateID'.
        /// </value>
        public int CurrencyRateID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CurrencyRateDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CurrencyRateDate'.
        /// </value>
        public DateTime CurrencyRateDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FromCurrencyCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FromCurrencyCode'.
        /// </value>
        public string FromCurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ToCurrencyCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ToCurrencyCode'.
        /// </value>
        public string ToCurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AverageRate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AverageRate'.
        /// </value>
        public decimal AverageRate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EndOfDayRate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EndOfDayRate'.
        /// </value>
        public decimal EndOfDayRate { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Currency" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Currency" />.
        /// </value>
        /// <seealso cref="FromCurrencyCode" />
        public virtual Currency FromCurrency {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </value>
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Currency" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Currency" />.
        /// </value>
        /// <seealso cref="ToCurrencyCode" />
        public virtual Currency ToCurrency {get; set; }
        
        #endregion // Generated Relationships
    }
}
