using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Shift'
    /// </summary>
    public partial class Shift
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shift"/> class.
        /// </summary>
        public Shift()
        {
            #region Generated Constructor

            EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ShiftID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ShiftID'.
        /// </value>
        public byte ShiftID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'StartTime'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StartTime'.
        /// </value>
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EndTime'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EndTime'.
        /// </value>
        public TimeSpan EndTime { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="EmployeeDepartmentHistory" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="EmployeeDepartmentHistory" />.
        /// </value>
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

        #endregion // Generated Relationships
    }
}
