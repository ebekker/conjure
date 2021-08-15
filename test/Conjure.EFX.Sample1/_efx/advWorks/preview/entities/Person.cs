using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Person'
    /// </summary>
    public partial class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
            #region Generated Constructor

            BusinessEntityContacts = new HashSet<BusinessEntityContact>();
            Customers = new HashSet<Customer>();
            EmailAddresses = new HashSet<EmailAddress>();
            PersonCreditCards = new HashSet<PersonCreditCard>();
            PersonPhones = new HashSet<PersonPhone>();

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
        /// Gets or sets the property value representing column 'PersonType'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PersonType'.
        /// </value>
        public string PersonType { get; set; }

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
        /// Gets or sets the property value representing column 'EmailPromotion'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EmailPromotion'.
        /// </value>
        public int EmailPromotion { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AdditionalContactInfo'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AdditionalContactInfo'.
        /// </value>
        public string AdditionalContactInfo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Demographics'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Demographics'.
        /// </value>
        public string Demographics { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="BusinessEntity" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="BusinessEntity" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual BusinessEntity BusinessEntity {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="BusinessEntityContact" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="BusinessEntityContact" />.
        /// </value>
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="Customer" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="Customer" />.
        /// </value>
        public virtual ICollection<Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="EmailAddress" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="EmailAddress" />.
        /// </value>
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Employee" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Employee" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual Employee Employee {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Password" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Password" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual Password Password {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="PersonCreditCard" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="PersonCreditCard" />.
        /// </value>
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="PersonPhone" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="PersonPhone" />.
        /// </value>
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }

        #endregion // Generated Relationships
    }
}
