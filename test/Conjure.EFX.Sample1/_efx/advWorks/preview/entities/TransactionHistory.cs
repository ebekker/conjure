using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'TransactionHistory'
    /// </summary>
    public partial class TransactionHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionHistory"/> class.
        /// </summary>
        public TransactionHistory()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'TransactionID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TransactionID'.
        /// </value>
        public int TransactionID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductID'.
        /// </value>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ReferenceOrderID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ReferenceOrderID'.
        /// </value>
        public int ReferenceOrderID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ReferenceOrderLineID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ReferenceOrderLineID'.
        /// </value>
        public int ReferenceOrderLineID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TransactionDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TransactionDate'.
        /// </value>
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TransactionType'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TransactionType'.
        /// </value>
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Quantity'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Quantity'.
        /// </value>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ActualCost'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ActualCost'.
        /// </value>
        public decimal ActualCost { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Product" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Product" />.
        /// </value>
        /// <seealso cref="ProductID" />
        public virtual Product Product {get; set; }
        
        #endregion // Generated Relationships
    }
}
