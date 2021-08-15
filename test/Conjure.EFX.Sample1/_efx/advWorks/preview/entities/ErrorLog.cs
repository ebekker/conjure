using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ErrorLog'
    /// </summary>
    public partial class ErrorLog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorLog"/> class.
        /// </summary>
        public ErrorLog()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ErrorLogID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ErrorLogID'.
        /// </value>
        public int ErrorLogID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ErrorTime'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ErrorTime'.
        /// </value>
        public DateTime ErrorTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UserName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UserName'.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ErrorNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ErrorNumber'.
        /// </value>
        public int ErrorNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ErrorSeverity'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ErrorSeverity'.
        /// </value>
        public int? ErrorSeverity { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ErrorState'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ErrorState'.
        /// </value>
        public int? ErrorState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ErrorProcedure'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ErrorProcedure'.
        /// </value>
        public string ErrorProcedure { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ErrorLine'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ErrorLine'.
        /// </value>
        public int? ErrorLine { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ErrorMessage'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ErrorMessage'.
        /// </value>
        public string ErrorMessage { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}
