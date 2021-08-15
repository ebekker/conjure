using System;
using System.Collections.Generic;

namespace AdvWorksLT.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'vProductAndDescription'
    /// </summary>
    public partial class VProductAndDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VProductAndDescription"/> class.
        /// </summary>
        public VProductAndDescription()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ProductID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductID'.
        /// </value>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductModel'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductModel'.
        /// </value>
        public string ProductModel { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Culture'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Culture'.
        /// </value>
        public string Culture { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Description'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Description'.
        /// </value>
        public string Description { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}
