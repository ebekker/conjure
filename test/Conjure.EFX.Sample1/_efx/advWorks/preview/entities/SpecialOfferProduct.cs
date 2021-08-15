using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'SpecialOfferProduct'
    /// </summary>
    public partial class SpecialOfferProduct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialOfferProduct"/> class.
        /// </summary>
        public SpecialOfferProduct()
        {
            #region Generated Constructor

            SalesOrderDetails = new HashSet<SalesOrderDetail>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'SpecialOfferID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SpecialOfferID'.
        /// </value>
        public int SpecialOfferID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductID'.
        /// </value>
        public int ProductID { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Product" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Product" />.
        /// </value>
        /// <seealso cref="ProductID" />
        public virtual Product Product {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SalesOrderDetail" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SalesOrderDetail" />.
        /// </value>
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="SpecialOffer" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="SpecialOffer" />.
        /// </value>
        /// <seealso cref="SpecialOfferID" />
        public virtual SpecialOffer SpecialOffer {get; set; }
        
        #endregion // Generated Relationships
    }
}
