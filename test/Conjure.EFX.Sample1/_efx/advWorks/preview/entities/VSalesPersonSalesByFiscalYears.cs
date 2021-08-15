using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'vSalesPersonSalesByFiscalYears'
    /// </summary>
    public partial class VSalesPersonSalesByFiscalYears
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VSalesPersonSalesByFiscalYears"/> class.
        /// </summary>
        public VSalesPersonSalesByFiscalYears()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'SalesPersonID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesPersonID'.
        /// </value>
        public int? SalesPersonID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FullName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FullName'.
        /// </value>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'JobTitle'.
        /// </summary>
        /// <value>
        /// The property value representing column 'JobTitle'.
        /// </value>
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalesTerritory'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesTerritory'.
        /// </value>
        public string SalesTerritory { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column '2002'.
        /// </summary>
        /// <value>
        /// The property value representing column '2002'.
        /// </value>
        public decimal? Number2002 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column '2003'.
        /// </summary>
        /// <value>
        /// The property value representing column '2003'.
        /// </value>
        public decimal? Number2003 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column '2004'.
        /// </summary>
        /// <value>
        /// The property value representing column '2004'.
        /// </value>
        public decimal? Number2004 { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}
