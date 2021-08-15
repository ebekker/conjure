using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'EmployeePayHistory'
    /// </summary>
    public partial class EmployeePayHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeePayHistory"/> class.
        /// </summary>
        public EmployeePayHistory()
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
        /// Gets or sets the property value representing column 'RateChangeDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RateChangeDate'.
        /// </value>
        public DateTime RateChangeDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Rate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Rate'.
        /// </value>
        public decimal Rate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PayFrequency'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PayFrequency'.
        /// </value>
        public byte PayFrequency { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Employee" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Employee" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual Employee Employee {get; set; }
        
        #endregion // Generated Relationships
    }
}
