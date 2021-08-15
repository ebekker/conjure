using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'SpecialOffer'
    /// </summary>
    public partial class SpecialOffer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialOffer"/> class.
        /// </summary>
        public SpecialOffer()
        {
            #region Generated Constructor

            SpecialOfferProducts = new HashSet<SpecialOfferProduct>();

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
        /// Gets or sets the property value representing column 'Description'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Description'.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DiscountPct'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DiscountPct'.
        /// </value>
        public decimal DiscountPct { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Type'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Type'.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Category'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Category'.
        /// </value>
        public string Category { get; set; }

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
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MinQty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MinQty'.
        /// </value>
        public int MinQty { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MaxQty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MaxQty'.
        /// </value>
        public int? MaxQty { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="SpecialOfferProduct" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SpecialOfferProduct" />.
        /// </value>
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }

        #endregion // Generated Relationships
    }
}
