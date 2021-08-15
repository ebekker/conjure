using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'vPersonDemographics'
    /// </summary>
    public partial class VPersonDemographics
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VPersonDemographics"/> class.
        /// </summary>
        public VPersonDemographics()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'BusinessEntityID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BusinessEntityID'.
        /// </value>
        public int BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TotalPurchaseYTD'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TotalPurchaseYTD'.
        /// </value>
        public decimal? TotalPurchaseYTD { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DateFirstPurchase'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DateFirstPurchase'.
        /// </value>
        public DateTime? DateFirstPurchase { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BirthDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BirthDate'.
        /// </value>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MaritalStatus'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MaritalStatus'.
        /// </value>
        public string MaritalStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'YearlyIncome'.
        /// </summary>
        /// <value>
        /// The property value representing column 'YearlyIncome'.
        /// </value>
        public string YearlyIncome { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Gender'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Gender'.
        /// </value>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TotalChildren'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TotalChildren'.
        /// </value>
        public int? TotalChildren { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NumberChildrenAtHome'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NumberChildrenAtHome'.
        /// </value>
        public int? NumberChildrenAtHome { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Education'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Education'.
        /// </value>
        public string Education { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Occupation'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Occupation'.
        /// </value>
        public string Occupation { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HomeOwnerFlag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HomeOwnerFlag'.
        /// </value>
        public bool? HomeOwnerFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NumberCarsOwned'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NumberCarsOwned'.
        /// </value>
        public int? NumberCarsOwned { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}
