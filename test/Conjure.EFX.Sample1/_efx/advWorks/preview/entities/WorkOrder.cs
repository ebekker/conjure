using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'WorkOrder'
    /// </summary>
    public partial class WorkOrder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrder"/> class.
        /// </summary>
        public WorkOrder()
        {
            #region Generated Constructor

            WorkOrderRoutings = new HashSet<WorkOrderRouting>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'WorkOrderID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WorkOrderID'.
        /// </value>
        public int WorkOrderID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductID'.
        /// </value>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OrderQty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OrderQty'.
        /// </value>
        public int OrderQty { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'StockedQty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StockedQty'.
        /// </value>
        public int StockedQty { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ScrappedQty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ScrappedQty'.
        /// </value>
        public short ScrappedQty { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'StartDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StartDate'.
        /// </value>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EndDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EndDate'.
        /// </value>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DueDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DueDate'.
        /// </value>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ScrapReasonID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ScrapReasonID'.
        /// </value>
        public short? ScrapReasonID { get; set; }

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
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="ScrapReason" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="ScrapReason" />.
        /// </value>
        /// <seealso cref="ScrapReasonID" />
        public virtual ScrapReason ScrapReason {get; set; }
        
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
