using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ScrapReason'
    /// </summary>
    public partial class ScrapReason
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapReason"/> class.
        /// </summary>
        public ScrapReason()
        {
            #region Generated Constructor

            WorkOrders = new HashSet<WorkOrder>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ScrapReasonID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ScrapReasonID'.
        /// </value>
        public short ScrapReasonID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="WorkOrder" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="WorkOrder" />.
        /// </value>
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }

        #endregion // Generated Relationships
    }
}
