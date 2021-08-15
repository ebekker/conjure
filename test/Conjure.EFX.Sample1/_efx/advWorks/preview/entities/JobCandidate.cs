using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'JobCandidate'
    /// </summary>
    public partial class JobCandidate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobCandidate"/> class.
        /// </summary>
        public JobCandidate()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'JobCandidateID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'JobCandidateID'.
        /// </value>
        public int JobCandidateID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BusinessEntityID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BusinessEntityID'.
        /// </value>
        public int? BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Resume'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Resume'.
        /// </value>
        public string Resume { get; set; }

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
