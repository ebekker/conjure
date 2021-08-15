using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'EmployeeDepartmentHistory'
    /// </summary>
    public partial class EmployeeDepartmentHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDepartmentHistory"/> class.
        /// </summary>
        public EmployeeDepartmentHistory()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'BusinessEntityID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BusinessEntityID'.
        /// </value>
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DepartmentID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DepartmentID'.
        /// </value>
        public short DepartmentID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ShiftID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ShiftID'.
        /// </value>
        public byte ShiftID { get; set; }

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
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public DateTime ModifiedDate { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Department" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Department" />.
        /// </value>
        /// <seealso cref="DepartmentID" />
        public virtual Department Department {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Employee" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Employee" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual Employee Employee {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Shift" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Shift" />.
        /// </value>
        /// <seealso cref="ShiftID" />
        public virtual Shift Shift {get; set; }
        
        #endregion // Generated Relationships
    }
}
