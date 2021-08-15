using System;
using System.Collections.Generic;

namespace AdvWorksLT.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Customer'
    /// </summary>
    public partial class Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
        {
            #region Generated Constructor

            CustomerAddresses = new HashSet<CustomerAddress>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'CustomerID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CustomerID'.
        /// </value>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NameStyle'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NameStyle'.
        /// </value>
        public bool NameStyle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Title'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Title'.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FirstName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FirstName'.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MiddleName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MiddleName'.
        /// </value>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LastName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LastName'.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Suffix'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Suffix'.
        /// </value>
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CompanyName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CompanyName'.
        /// </value>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalesPerson'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesPerson'.
        /// </value>
        public string SalesPerson { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EmailAddress'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EmailAddress'.
        /// </value>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Phone'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Phone'.
        /// </value>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PasswordHash'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PasswordHash'.
        /// </value>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PasswordSalt'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PasswordSalt'.
        /// </value>
        public string PasswordSalt { get; set; }

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
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        #endregion // Generated Relationships
    }
}
