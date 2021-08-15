using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'vProductModelInstructions'
    /// </summary>
    public partial class VProductModelInstructions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VProductModelInstructions"/> class.
        /// </summary>
        public VProductModelInstructions()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ProductModelID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductModelID'.
        /// </value>
        public int ProductModelID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Instructions'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Instructions'.
        /// </value>
        public string Instructions { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LocationID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LocationID'.
        /// </value>
        public int? LocationID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SetupHours'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SetupHours'.
        /// </value>
        public decimal? SetupHours { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MachineHours'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MachineHours'.
        /// </value>
        public decimal? MachineHours { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LaborHours'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LaborHours'.
        /// </value>
        public decimal? LaborHours { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LotSize'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LotSize'.
        /// </value>
        public int? LotSize { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Step'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Step'.
        /// </value>
        public string Step { get; set; }

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

        #endregion // Generated Relationships
    }
}
