using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'SalesTaxRate'
    /// </summary>
    public partial class SalesTaxRate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesTaxRate"/> class.
        /// </summary>
        public SalesTaxRate()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'SalesTaxRateID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalesTaxRateID'.
        /// </value>
        public int SalesTaxRateID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'StateProvinceID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StateProvinceID'.
        /// </value>
        public int StateProvinceID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TaxType'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TaxType'.
        /// </value>
        public byte TaxType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TaxRate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TaxRate'.
        /// </value>
        public decimal TaxRate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="StateProvince" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="StateProvince" />.
        /// </value>
        /// <seealso cref="StateProvinceID" />
        public virtual StateProvince StateProvince {get; set; }
        
        #endregion // Generated Relationships
    }
}
