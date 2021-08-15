using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'ProductReview'
    /// </summary>
    public partial class ProductReview
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductReview"/> class.
        /// </summary>
        public ProductReview()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ProductReviewID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductReviewID'.
        /// </value>
        public int ProductReviewID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductID'.
        /// </value>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ReviewerName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ReviewerName'.
        /// </value>
        public string ReviewerName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ReviewDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ReviewDate'.
        /// </value>
        public DateTime ReviewDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EmailAddress'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EmailAddress'.
        /// </value>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Rating'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Rating'.
        /// </value>
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Comments'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Comments'.
        /// </value>
        public string Comments { get; set; }

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
        
        #endregion // Generated Relationships
    }
}
