using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Location'
    /// </summary>
    public partial class Location
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        public Location()
        {
            #region Generated Constructor

            ProductInventories = new HashSet<ProductInventory>();
            WorkOrderRoutings = new HashSet<WorkOrderRouting>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'LocationID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LocationID'.
        /// </value>
        public short LocationID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CostRate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CostRate'.
        /// </value>
        public decimal CostRate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Availability'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Availability'.
        /// </value>
        public decimal Availability { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="ProductInventory" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductInventory" />.
        /// </value>
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="WorkOrderRouting" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="WorkOrderRouting" />.
        /// </value>
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }

        #endregion // Generated Relationships
    }
}
