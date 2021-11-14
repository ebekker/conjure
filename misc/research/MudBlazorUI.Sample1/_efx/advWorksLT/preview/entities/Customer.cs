#pragma warning disable IDE0073 // The file header is missing or not located at the top of the file
/** THIS IS AUTOGENERATED BY CONJURE EFX **/
#pragma warning restore IDE0073 // The file header is missing or not located at the top of the file

using System;
using System.Collections.Generic;

namespace ConjureApp.Data.Entities
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

            CustomerAddresses = new System.Collections.ObjectModel.ObservableCollection<CustomerAddress>();
            SalesOrderHeaders = new System.Collections.ObjectModel.ObservableCollection<SalesOrderHeader>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'CustomerID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CustomerID'.
        /// </value>
        public virtual int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NameStyle'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NameStyle'.
        /// </value>
        public virtual bool NameStyle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Title'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Title'.
        /// </value>
        public virtual string? Title { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FirstName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FirstName'.
        /// </value>
        public virtual string FirstName { get; set; } = default!;

        /// <summary>
        /// Gets or sets the property value representing column 'MiddleName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MiddleName'.
        /// </value>
        public virtual string? MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LastName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LastName'.
        /// </value>
        public virtual string LastName { get; set; } = default!;

        /// <summary>
        /// Gets or sets the property value representing column 'Suffix'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Suffix'.
        /// </value>
        public virtual string? Suffix { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CompanyName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CompanyName'.
        /// </value>
        public virtual string? CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalesPerson'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesPerson'.
        /// </value>
        public virtual string? SalesPerson { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EmailAddress'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EmailAddress'.
        /// </value>
        public virtual string? EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Phone'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Phone'.
        /// </value>
        public virtual string? Phone { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PasswordHash'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PasswordHash'.
        /// </value>
        public virtual string PasswordHash { get; set; } = default!;

        /// <summary>
        /// Gets or sets the property value representing column 'PasswordSalt'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PasswordSalt'.
        /// </value>
        public virtual string PasswordSalt { get; set; } = default!;

        /// <summary>
        /// Gets or sets the property value representing column 'rowguid'.
        /// </summary>
        /// <value>
        /// The property value representing column 'rowguid'.
        /// </value>
        public virtual Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public virtual DateTime ModifiedDate { get; set; }

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