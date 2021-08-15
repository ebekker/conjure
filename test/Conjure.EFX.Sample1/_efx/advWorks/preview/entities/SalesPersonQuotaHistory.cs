using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'SalesPersonQuotaHistory'
    /// </summary>
    public partial class SalesPersonQuotaHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesPersonQuotaHistory"/> class.
        /// </summary>
        public SalesPersonQuotaHistory()
        {
            #region Generated Constructor


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
        /// Gets or sets the property value representing column 'QuotaDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'QuotaDate'.
        /// </value>
        public DateTime QuotaDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalesQuota'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesQuota'.
        /// </value>
        public decimal SalesQuota { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="SalesPerson" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="SalesPerson" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual SalesPerson SalesPerson {get; set; }
        
        #endregion // Generated Relationships
    }
}
