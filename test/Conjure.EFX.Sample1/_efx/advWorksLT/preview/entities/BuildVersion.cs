using System;
using System.Collections.Generic;

namespace AdvWorksLT.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'BuildVersion'
    /// </summary>
    public partial class BuildVersion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildVersion"/> class.
        /// </summary>
        public BuildVersion()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'SystemInformationID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SystemInformationID'.
        /// </value>
        public byte SystemInformationID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Database Version'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Database Version'.
        /// </value>
        public string DatabaseVersion { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VersionDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VersionDate'.
        /// </value>
        public DateTime VersionDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public DateTime ModifiedDate { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}
