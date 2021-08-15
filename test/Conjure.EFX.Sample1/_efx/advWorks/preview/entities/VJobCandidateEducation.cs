using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'vJobCandidateEducation'
    /// </summary>
    public partial class VJobCandidateEducation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VJobCandidateEducation"/> class.
        /// </summary>
        public VJobCandidateEducation()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'JobCandidateID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'JobCandidateID'.
        /// </value>
        public int JobCandidateID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Edu.Level'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Edu.Level'.
        /// </value>
        public string EduLevel { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Edu.StartDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Edu.StartDate'.
        /// </value>
        public DateTime? EduStartDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Edu.EndDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Edu.EndDate'.
        /// </value>
        public DateTime? EduEndDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Edu.Degree'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Edu.Degree'.
        /// </value>
        public string EduDegree { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Edu.Major'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Edu.Major'.
        /// </value>
        public string EduMajor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Edu.Minor'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Edu.Minor'.
        /// </value>
        public string EduMinor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Edu.GPA'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Edu.GPA'.
        /// </value>
        public string EduGPA { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Edu.GPAScale'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Edu.GPAScale'.
        /// </value>
        public string EduGPAScale { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Edu.School'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Edu.School'.
        /// </value>
        public string EduSchool { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Edu.Loc.CountryRegion'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Edu.Loc.CountryRegion'.
        /// </value>
        public string EduLocCountryRegion { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Edu.Loc.State'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Edu.Loc.State'.
        /// </value>
        public string EduLocState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Edu.Loc.City'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Edu.Loc.City'.
        /// </value>
        public string EduLocCity { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}
