using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'AddressType'
    /// </summary>
    public partial class AddressType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressType"/> class.
        /// </summary>
        public AddressType()
        {
            #region Generated Constructor

            BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'AddressTypeID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AddressTypeID'.
        /// </value>
        public int AddressTypeID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="BusinessEntityAddress" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="BusinessEntityAddress" />.
        /// </value>
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

        #endregion // Generated Relationships
    }
}
