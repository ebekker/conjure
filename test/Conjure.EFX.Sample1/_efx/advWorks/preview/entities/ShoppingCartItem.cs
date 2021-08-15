using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ShoppingCartItem'
    /// </summary>
    public partial class ShoppingCartItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCartItem"/> class.
        /// </summary>
        public ShoppingCartItem()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ShoppingCartItemID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ShoppingCartItemID'.
        /// </value>
        public int ShoppingCartItemID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ShoppingCartID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ShoppingCartID'.
        /// </value>
        public string ShoppingCartID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Quantity'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Quantity'.
        /// </value>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductID'.
        /// </value>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DateCreated'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DateCreated'.
        /// </value>
        public DateTime DateCreated { get; set; }

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
