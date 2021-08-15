using System;
using System.Collections.Generic;

namespace AdvWorksLT.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Address'
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
        {
            #region Generated Constructor

            BillToSalesOrderHeaders = new HashSet<SalesOrderHeader>();
            CustomerAddresses = new HashSet<CustomerAddress>();
            ShipToSalesOrderHeaders = new HashSet<SalesOrderHeader>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'AddressID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AddressID'.
        /// </value>
        public int AddressID { get; set; }

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
        /// Gets or sets the property value representing column 'StateProvince'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StateProvince'.
        /// </value>
        public string StateProvince { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CountryRegion'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CountryRegion'.
        /// </value>
        public string CountryRegion { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PostalCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PostalCode'.
        /// </value>
        public string PostalCode { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </value>
        public virtual ICollection<SalesOrderHeader> BillToSalesOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="CustomerAddress" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="CustomerAddress" />.
        /// </value>
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </value>
        public virtual ICollection<SalesOrderHeader> ShipToSalesOrderHeaders { get; set; }

        #endregion // Generated Relationships
    }
}
