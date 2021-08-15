using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'BillOfMaterials'
    /// </summary>
    public partial class BillOfMaterials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillOfMaterials"/> class.
        /// </summary>
        public BillOfMaterials()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'BillOfMaterialsID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BillOfMaterialsID'.
        /// </value>
        public int BillOfMaterialsID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductAssemblyID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductAssemblyID'.
        /// </value>
        public int? ProductAssemblyID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ComponentID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ComponentID'.
        /// </value>
        public int ComponentID { get; set; }

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
        /// Gets or sets the property value representing column 'UnitMeasureCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UnitMeasureCode'.
        /// </value>
        public string UnitMeasureCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BOMLevel'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BOMLevel'.
        /// </value>
        public short BOMLevel { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PerAssemblyQty'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PerAssemblyQty'.
        /// </value>
        public decimal PerAssemblyQty { get; set; }

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
        /// <seealso cref="ProductAssemblyID" />
        public virtual Product AssemblyProduct {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Product" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Product" />.
        /// </value>
        /// <seealso cref="ComponentID" />
        public virtual Product ComponentProduct {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="UnitMeasure" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="UnitMeasure" />.
        /// </value>
        /// <seealso cref="UnitMeasureCode" />
        public virtual UnitMeasure UnitMeasure {get; set; }
        
        #endregion // Generated Relationships
    }
}
