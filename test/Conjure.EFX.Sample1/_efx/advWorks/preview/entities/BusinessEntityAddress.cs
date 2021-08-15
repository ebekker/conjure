using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'BusinessEntityAddress'
    /// </summary>
    public partial class BusinessEntityAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessEntityAddress"/> class.
        /// </summary>
        public BusinessEntityAddress()
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
        /// Gets or sets the property value representing column 'AddressID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AddressID'.
        /// </value>
        public int AddressID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AddressTypeID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AddressTypeID'.
        /// </value>
        public int AddressTypeID { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Address" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Address" />.
        /// </value>
        /// <seealso cref="AddressID" />
        public virtual Address Address {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="AddressType" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="AddressType" />.
        /// </value>
        /// <seealso cref="AddressTypeID" />
        public virtual AddressType AddressType {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="BusinessEntity" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="BusinessEntity" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual BusinessEntity BusinessEntity {get; set; }
        
        #endregion // Generated Relationships
    }
}
