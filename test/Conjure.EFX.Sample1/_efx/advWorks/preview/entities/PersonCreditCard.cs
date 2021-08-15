using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'PersonCreditCard'
    /// </summary>
    public partial class PersonCreditCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCreditCard"/> class.
        /// </summary>
        public PersonCreditCard()
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
        /// Gets or sets the property value representing column 'CreditCardID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreditCardID'.
        /// </value>
        public int CreditCardID { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="CreditCard" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="CreditCard" />.
        /// </value>
        /// <seealso cref="CreditCardID" />
        public virtual CreditCard CreditCard {get; set; }
        
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
