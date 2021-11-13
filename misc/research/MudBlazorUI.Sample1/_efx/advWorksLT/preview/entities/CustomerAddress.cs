#pragma warning disable IDE0073 // The file header is missing or not located at the top of the file
/** THIS IS AUTOGENERATED BY CONJURE EFX **/
#pragma warning restore IDE0073 // The file header is missing or not located at the top of the file

using System;
using System.Collections.Generic;

namespace ConjureApp.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'CustomerAddress'
    /// </summary>
    public partial class CustomerAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAddress"/> class.
        /// </summary>
        public CustomerAddress()
        {
            #region Generated Constructor


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
        /// Gets or sets the property value representing column 'AddressID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AddressID'.
        /// </value>
        public virtual int AddressID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AddressType'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AddressType'.
        /// </value>
        public virtual string AddressType { get; set; } = default!;

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
        /// Gets or sets the navigation property for entity <see cref="Address" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Address" />.
        /// </value>
        /// <seealso cref="AddressID" />
        public virtual Address Address {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Customer" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Customer" />.
        /// </value>
        /// <seealso cref="CustomerID" />
        public virtual Customer Customer {get; set; }
        
        #endregion // Generated Relationships
    }
}
