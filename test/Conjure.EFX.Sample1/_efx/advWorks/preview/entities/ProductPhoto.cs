using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ProductPhoto'
    /// </summary>
    public partial class ProductPhoto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPhoto"/> class.
        /// </summary>
        public ProductPhoto()
        {
            #region Generated Constructor

            ProductProductPhotos = new HashSet<ProductProductPhoto>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ProductPhotoID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductPhotoID'.
        /// </value>
        public int ProductPhotoID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ThumbNailPhoto'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ThumbNailPhoto'.
        /// </value>
        public Byte[] ThumbNailPhoto { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ThumbnailPhotoFileName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ThumbnailPhotoFileName'.
        /// </value>
        public string ThumbnailPhotoFileName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LargePhoto'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LargePhoto'.
        /// </value>
        public Byte[] LargePhoto { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LargePhotoFileName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LargePhotoFileName'.
        /// </value>
        public string LargePhotoFileName { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="ProductProductPhoto" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductProductPhoto" />.
        /// </value>
        public virtual ICollection<ProductProductPhoto> ProductProductPhotos { get; set; }

        #endregion // Generated Relationships
    }
}
