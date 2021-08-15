using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'vEmployeeDepartmentHistory'
    /// </summary>
    public partial class VEmployeeDepartmentHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VEmployeeDepartmentHistory"/> class.
        /// </summary>
        public VEmployeeDepartmentHistory()
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
        /// Gets or sets the property value representing column 'Title'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Title'.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FirstName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FirstName'.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MiddleName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MiddleName'.
        /// </value>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LastName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LastName'.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Suffix'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Suffix'.
        /// </value>
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Shift'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Shift'.
        /// </value>
        public string Shift { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Department'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Department'.
        /// </value>
        public string Department { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GroupName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GroupName'.
        /// </value>
        public string GroupName { get; set; }

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

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}
