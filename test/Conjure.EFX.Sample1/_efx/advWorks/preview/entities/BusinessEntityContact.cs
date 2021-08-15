using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'BusinessEntityContact'
    /// </summary>
    public partial class BusinessEntityContact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessEntityContact"/> class.
        /// </summary>
        public BusinessEntityContact()
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
        /// Gets or sets the property value representing column 'PersonID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PersonID'.
        /// </value>
        public int PersonID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ContactTypeID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ContactTypeID'.
        /// </value>
        public int ContactTypeID { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="ContactType" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="ContactType" />.
        /// </value>
        /// <seealso cref="ContactTypeID" />
        public virtual ContactType ContactType {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Person" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Person" />.
        /// </value>
        /// <seealso cref="PersonID" />
        public virtual Person Person {get; set; }
        
        #endregion // Generated Relationships
    }
}
