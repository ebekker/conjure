using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'SalesOrderHeaderSalesReason'
    /// </summary>
    public partial class SalesOrderHeaderSalesReason
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderHeaderSalesReason"/> class.
        /// </summary>
        public SalesOrderHeaderSalesReason()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'SalesOrderID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesOrderID'.
        /// </value>
        public int SalesOrderID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalesReasonID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesReasonID'.
        /// </value>
        public int SalesReasonID { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="SalesOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="SalesOrderHeader" />.
        /// </value>
        /// <seealso cref="SalesOrderID" />
        public virtual SalesOrderHeader SalesOrderHeader {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="SalesReason" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="SalesReason" />.
        /// </value>
        /// <seealso cref="SalesReasonID" />
        public virtual SalesReason SalesReason {get; set; }
        
        #endregion // Generated Relationships
    }
}
