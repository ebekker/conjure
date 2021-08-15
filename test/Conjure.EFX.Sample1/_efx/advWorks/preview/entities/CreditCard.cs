using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'CreditCard'
    /// </summary>
    public partial class CreditCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCard"/> class.
        /// </summary>
        public CreditCard()
        {
            #region Generated Constructor

            PersonCreditCards = new HashSet<PersonCreditCard>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'CreditCardID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreditCardID'.
        /// </value>
        public int CreditCardID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CardType'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CardType'.
        /// </value>
        public string CardType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CardNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CardNumber'.
        /// </value>
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ExpMonth'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ExpMonth'.
        /// </value>
        public byte ExpMonth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ExpYear'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ExpYear'.
        /// </value>
        public short ExpYear { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="PersonCreditCard" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="PersonCreditCard" />.
        /// </value>
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderHeader" />.
        /// </value>
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        #endregion // Generated Relationships
    }
}
