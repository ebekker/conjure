using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'PhoneNumberType'
    /// </summary>
    public partial class PhoneNumberType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberType"/> class.
        /// </summary>
        public PhoneNumberType()
        {
            #region Generated Constructor

            PersonPhones = new HashSet<PersonPhone>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'PhoneNumberTypeID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PhoneNumberTypeID'.
        /// </value>
        public int PhoneNumberTypeID { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="PersonPhone" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="PersonPhone" />.
        /// </value>
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }

        #endregion // Generated Relationships
    }
}
