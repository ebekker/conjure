using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'DatabaseLog'
    /// </summary>
    public partial class DatabaseLog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseLog"/> class.
        /// </summary>
        public DatabaseLog()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'DatabaseLogID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DatabaseLogID'.
        /// </value>
        public int DatabaseLogID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PostTime'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PostTime'.
        /// </value>
        public DateTime PostTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DatabaseUser'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DatabaseUser'.
        /// </value>
        public string DatabaseUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Event'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Event'.
        /// </value>
        public string Event { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Schema'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Schema'.
        /// </value>
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Object'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Object'.
        /// </value>
        public string Object { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TSQL'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TSQL'.
        /// </value>
        public string Tsql { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'XmlEvent'.
        /// </summary>
        /// <value>
        /// The property value representing column 'XmlEvent'.
        /// </value>
        public string XmlEvent { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}
