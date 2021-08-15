using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'UnitMeasure'
    /// </summary>
    public partial class UnitMeasure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitMeasure"/> class.
        /// </summary>
        public UnitMeasure()
        {
            #region Generated Constructor

            BillOfMaterials = new HashSet<BillOfMaterials>();
            ProductVendors = new HashSet<ProductVendor>();
            SizeProducts = new HashSet<Product>();
            WeightProducts = new HashSet<Product>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'UnitMeasureCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UnitMeasureCode'.
        /// </value>
        public string UnitMeasureCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="BillOfMaterials" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="BillOfMaterials" />.
        /// </value>
        public virtual ICollection<BillOfMaterials> BillOfMaterials { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="ProductVendor" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductVendor" />.
        /// </value>
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="Product" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="Product" />.
        /// </value>
        public virtual ICollection<Product> SizeProducts { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="Product" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="Product" />.
        /// </value>
        public virtual ICollection<Product> WeightProducts { get; set; }

        #endregion // Generated Relationships
    }
}
