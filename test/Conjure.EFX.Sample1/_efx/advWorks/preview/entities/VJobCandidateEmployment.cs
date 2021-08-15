using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'vJobCandidateEmployment'
    /// </summary>
    public partial class VJobCandidateEmployment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VJobCandidateEmployment"/> class.
        /// </summary>
        public VJobCandidateEmployment()
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
        /// Gets or sets the property value representing column 'Emp.StartDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Emp.StartDate'.
        /// </value>
        public DateTime? EmpStartDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Emp.EndDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Emp.EndDate'.
        /// </value>
        public DateTime? EmpEndDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Emp.OrgName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Emp.OrgName'.
        /// </value>
        public string EmpOrgName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Emp.JobTitle'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Emp.JobTitle'.
        /// </value>
        public string EmpJobTitle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Emp.Responsibility'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Emp.Responsibility'.
        /// </value>
        public string EmpResponsibility { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Emp.FunctionCategory'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Emp.FunctionCategory'.
        /// </value>
        public string EmpFunctionCategory { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Emp.IndustryCategory'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Emp.IndustryCategory'.
        /// </value>
        public string EmpIndustryCategory { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Emp.Loc.CountryRegion'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Emp.Loc.CountryRegion'.
        /// </value>
        public string EmpLocCountryRegion { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Emp.Loc.State'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Emp.Loc.State'.
        /// </value>
        public string EmpLocState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Emp.Loc.City'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Emp.Loc.City'.
        /// </value>
        public string EmpLocCity { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}
