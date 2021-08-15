using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ProductInventory'
    /// </summary>
    public partial class ProductInventory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductInventory"/> class.
        /// </summary>
        public ProductInventory()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ProductID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductID'.
        /// </value>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LocationID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LocationID'.
        /// </value>
        public short LocationID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Shelf'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Shelf'.
        /// </value>
        public string Shelf { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Bin'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Bin'.
        /// </value>
        public byte Bin { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Quantity'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Quantity'.
        /// </value>
        public short Quantity { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Location" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Location" />.
        /// </value>
        /// <seealso cref="LocationID" />
        public virtual Location Location {get; set; }
        
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
