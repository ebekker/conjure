using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Employee'
    /// </summary>
    public partial class Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee()
        {
            #region Generated Constructor

            EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
            EmployeePayHistories = new HashSet<EmployeePayHistory>();
            JobCandidates = new HashSet<JobCandidate>();
            PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();

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
        /// Gets or sets the property value representing column 'NationalIDNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NationalIDNumber'.
        /// </value>
        public string NationalIDNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LoginID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LoginID'.
        /// </value>
        public string LoginID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OrganizationLevel'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OrganizationLevel'.
        /// </value>
        public short? OrganizationLevel { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'JobTitle'.
        /// </summary>
        /// <value>
        /// The property value representing column 'JobTitle'.
        /// </value>
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BirthDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BirthDate'.
        /// </value>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MaritalStatus'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MaritalStatus'.
        /// </value>
        public string MaritalStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Gender'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Gender'.
        /// </value>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HireDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HireDate'.
        /// </value>
        public DateTime HireDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SalariedFlag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SalariedFlag'.
        /// </value>
        public bool SalariedFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VacationHours'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VacationHours'.
        /// </value>
        public short VacationHours { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SickLeaveHours'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SickLeaveHours'.
        /// </value>
        public short SickLeaveHours { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CurrentFlag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CurrentFlag'.
        /// </value>
        public bool CurrentFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'rowguid'.
        /// </summary>
        /// <value>
        /// The property value representing column 'rowguid'.
        /// </value>
        public Guid Rowguid { get; set; }

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
        /// Gets or sets the navigation collection for entity <see cref="EmployeeDepartmentHistory" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="EmployeeDepartmentHistory" />.
        /// </value>
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="EmployeePayHistory" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="EmployeePayHistory" />.
        /// </value>
        public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="JobCandidate" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="JobCandidate" />.
        /// </value>
        public virtual ICollection<JobCandidate> JobCandidates { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="Person" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="Person" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual Person Person {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="PurchaseOrderHeader" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="PurchaseOrderHeader" />.
        /// </value>
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="SalesPerson" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="SalesPerson" />.
        /// </value>
        /// <seealso cref="BusinessEntityID" />
        public virtual SalesPerson SalesPerson {get; set; }
        
        #endregion // Generated Relationships
    }
}
