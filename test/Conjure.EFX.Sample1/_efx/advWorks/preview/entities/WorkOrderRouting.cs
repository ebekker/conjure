using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'WorkOrderRouting'
    /// </summary>
    public partial class WorkOrderRouting
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkOrderRouting"/> class.
        /// </summary>
        public WorkOrderRouting()
        {
            #region Generated Constructor


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
        /// Gets or sets the property value representing column 'OperationSequence'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OperationSequence'.
        /// </value>
        public short OperationSequence { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LocationID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LocationID'.
        /// </value>
        public short LocationID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ScheduledStartDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ScheduledStartDate'.
        /// </value>
        public DateTime ScheduledStartDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ScheduledEndDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ScheduledEndDate'.
        /// </value>
        public DateTime ScheduledEndDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ActualStartDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ActualStartDate'.
        /// </value>
        public DateTime? ActualStartDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ActualEndDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ActualEndDate'.
        /// </value>
        public DateTime? ActualEndDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ActualResourceHrs'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ActualResourceHrs'.
        /// </value>
        public decimal? ActualResourceHrs { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PlannedCost'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PlannedCost'.
        /// </value>
        public decimal PlannedCost { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ActualCost'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ActualCost'.
        /// </value>
        public decimal? ActualCost { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="WorkOrder" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="WorkOrder" />.
        /// </value>
        /// <seealso cref="WorkOrderID" />
        public virtual WorkOrder WorkOrder {get; set; }
        
        #endregion // Generated Relationships
    }
}
