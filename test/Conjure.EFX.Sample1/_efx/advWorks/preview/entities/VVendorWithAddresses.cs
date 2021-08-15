using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'vVendorWithAddresses'
    /// </summary>
    public partial class VVendorWithAddresses
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VVendorWithAddresses"/> class.
        /// </summary>
        public VVendorWithAddresses()
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
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AddressType'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AddressType'.
        /// </value>
        public string AddressType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AddressLine1'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AddressLine1'.
        /// </value>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AddressLine2'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AddressLine2'.
        /// </value>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'City'.
        /// </summary>
        /// <value>
        /// The property value representing column 'City'.
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'StateProvinceName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StateProvinceName'.
        /// </value>
        public string StateProvinceName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PostalCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PostalCode'.
        /// </value>
        public string PostalCode { get; set; }

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
