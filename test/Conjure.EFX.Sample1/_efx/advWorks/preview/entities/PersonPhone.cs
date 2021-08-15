using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'PersonPhone'
    /// </summary>
    public partial class PersonPhone
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonPhone"/> class.
        /// </summary>
        public PersonPhone()
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
        /// Gets or sets the property value representing column 'PhoneNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PhoneNumber'.
        /// </value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PhoneNumberTypeID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PhoneNumberTypeID'.
        /// </value>
        public int PhoneNumberTypeID { get; set; }

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
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="PhoneNumberType" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="PhoneNumberType" />.
        /// </value>
        /// <seealso cref="PhoneNumberTypeID" />
        public virtual PhoneNumberType PhoneNumberType {get; set; }
        
        #endregion // Generated Relationships
    }
}
