using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ContactType'
    /// </summary>
    public partial class ContactType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactType"/> class.
        /// </summary>
        public ContactType()
        {
            #region Generated Constructor

            BusinessEntityContacts = new HashSet<BusinessEntityContact>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ContactTypeID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ContactTypeID'.
        /// </value>
        public int ContactTypeID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="BusinessEntityContact" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="BusinessEntityContact" />.
        /// </value>
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

        #endregion // Generated Relationships
    }
}
