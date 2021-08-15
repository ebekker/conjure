using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'EmailAddress'
    /// </summary>
    public partial class EmailAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAddress"/> class.
        /// </summary>
        public EmailAddress()
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
        /// Gets or sets the property value representing column 'EmailAddressID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EmailAddressID'.
        /// </value>
        public int EmailAddressID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EmailAddress'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EmailAddress'.
        /// </value>
        public string EmailAddressMember { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Person" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Person" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual Person Person {get; set; }
        
        #endregion // Generated Relationships
    }
}
