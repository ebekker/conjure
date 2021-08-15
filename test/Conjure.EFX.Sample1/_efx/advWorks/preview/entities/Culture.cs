using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Culture'
    /// </summary>
    public partial class Culture
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Culture"/> class.
        /// </summary>
        public Culture()
        {
            #region Generated Constructor

            ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'CultureID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CultureID'.
        /// </value>
        public string CultureID { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="ProductModelProductDescriptionCulture" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductModelProductDescriptionCulture" />.
        /// </value>
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

        #endregion // Generated Relationships
    }
}
