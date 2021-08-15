using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Illustration'
    /// </summary>
    public partial class Illustration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Illustration"/> class.
        /// </summary>
        public Illustration()
        {
            #region Generated Constructor

            ProductModelIllustrations = new HashSet<ProductModelIllustration>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'IllustrationID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IllustrationID'.
        /// </value>
        public int IllustrationID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Diagram'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Diagram'.
        /// </value>
        public string Diagram { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="ProductModelIllustration" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductModelIllustration" />.
        /// </value>
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }

        #endregion // Generated Relationships
    }
}
