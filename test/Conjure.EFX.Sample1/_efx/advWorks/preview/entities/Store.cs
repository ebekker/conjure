using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Store'
    /// </summary>
    public partial class Store
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Store"/> class.
        /// </summary>
        public Store()
        {
            #region Generated Constructor

            Customers = new HashSet<Customer>();

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
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalesPersonID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesPersonID'.
        /// </value>
        public int? SalesPersonID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Demographics'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Demographics'.
        /// </value>
        public string Demographics { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="BusinessEntity" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="BusinessEntity" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual BusinessEntity BusinessEntity {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="Customer" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="Customer" />.
        /// </value>
        public virtual ICollection<Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="SalesPerson" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="SalesPerson" />.
        /// </value>
        /// <seealso cref="SalesPersonID" />
        public virtual SalesPerson SalesPerson {get; set; }
        
        #endregion // Generated Relationships
    }
}
