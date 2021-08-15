using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'BusinessEntity'
    /// </summary>
    public partial class BusinessEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessEntity"/> class.
        /// </summary>
        public BusinessEntity()
        {
            #region Generated Constructor

            BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
            BusinessEntityContacts = new HashSet<BusinessEntityContact>();

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

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="BusinessEntityContact" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="BusinessEntityContact" />.
        /// </value>
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Person" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Person" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual Person Person {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Store" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Store" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual Store Store {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Vendor" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Vendor" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual Vendor Vendor {get; set; }
        
        #endregion // Generated Relationships
    }
}
