using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'vStateProvinceCountryRegion'
    /// </summary>
    public partial class VStateProvinceCountryRegion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VStateProvinceCountryRegion"/> class.
        /// </summary>
        public VStateProvinceCountryRegion()
        {
            #region Generated Constructor


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
        /// Gets or sets the property value representing column 'IsOnlyStateProvinceFlag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IsOnlyStateProvinceFlag'.
        /// </value>
        public bool IsOnlyStateProvinceFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'StateProvinceName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StateProvinceName'.
        /// </value>
        public string StateProvinceName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TerritoryID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TerritoryID'.
        /// </value>
        public int TerritoryID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CountryRegionCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CountryRegionCode'.
        /// </value>
        public string CountryRegionCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CountryRegionName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CountryRegionName'.
        /// </value>
        public string CountryRegionName { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}
