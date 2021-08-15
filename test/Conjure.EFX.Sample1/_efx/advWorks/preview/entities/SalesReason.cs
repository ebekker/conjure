using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'SalesReason'
    /// </summary>
    public partial class SalesReason
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesReason"/> class.
        /// </summary>
        public SalesReason()
        {
            #region Generated Constructor

            SalesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'SalesReasonID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesReasonID'.
        /// </value>
        public int SalesReasonID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ReasonType'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ReasonType'.
        /// </value>
        public string ReasonType { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeaderSalesReason" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderHeaderSalesReason" />.
        /// </value>
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

        #endregion // Generated Relationships
    }
}
