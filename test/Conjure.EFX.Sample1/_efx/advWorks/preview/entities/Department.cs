using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Department'
    /// </summary>
    public partial class Department
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Department"/> class.
        /// </summary>
        public Department()
        {
            #region Generated Constructor

            EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'DepartmentID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DepartmentID'.
        /// </value>
        public short DepartmentID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GroupName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GroupName'.
        /// </value>
        public string GroupName { get; set; }

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
