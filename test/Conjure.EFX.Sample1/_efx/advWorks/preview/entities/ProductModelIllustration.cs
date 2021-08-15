using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ProductModelIllustration'
    /// </summary>
    public partial class ProductModelIllustration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModelIllustration"/> class.
        /// </summary>
        public ProductModelIllustration()
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
        /// Gets or sets the property value representing column 'IllustrationID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IllustrationID'.
        /// </value>
        public int IllustrationID { get; set; }

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
        /// Gets or sets the navigation property for entity <see cref="Illustration" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Illustration" />.
        /// </value>
        /// <seealso cref="IllustrationID" />
        public virtual Illustration Illustration {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="ProductModel" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="ProductModel" />.
        /// </value>
        /// <seealso cref="ProductModelID" />
        public virtual ProductModel ProductModel {get; set; }
        
        #endregion // Generated Relationships
    }
}
