using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'SalesTerritoryHistory'
    /// </summary>
    public partial class SalesTerritoryHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesTerritoryHistory"/> class.
        /// </summary>
        public SalesTerritoryHistory()
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
        /// Gets or sets the property value representing column 'TerritoryID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TerritoryID'.
        /// </value>
        public int TerritoryID { get; set; }

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
        /// Gets or sets the property value representing column 'rowguid'.
        /// </summary>
        /// <value>
        /// The property value representing column 'rowguid'.
        /// </value>
        public Guid Rowguid { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="SalesPerson" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="SalesPerson" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual SalesPerson SalesPerson {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="SalesTerritory" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="SalesTerritory" />.
        /// </value>
        /// <seealso cref="TerritoryID" />
        public virtual SalesTerritory SalesTerritory {get; set; }
        
        #endregion // Generated Relationships
    }
}
