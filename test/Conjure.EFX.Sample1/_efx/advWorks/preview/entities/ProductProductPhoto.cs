using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ProductProductPhoto'
    /// </summary>
    public partial class ProductProductPhoto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductProductPhoto"/> class.
        /// </summary>
        public ProductProductPhoto()
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
        /// Gets or sets the property value representing column 'ProductPhotoID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductPhotoID'.
        /// </value>
        public int ProductPhotoID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Primary'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Primary'.
        /// </value>
        public bool Primary { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="ProductPhoto" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="ProductPhoto" />.
        /// </value>
        /// <seealso cref="ProductPhotoID" />
        public virtual ProductPhoto ProductPhoto {get; set; }
        
        #endregion // Generated Relationships
    }
}
