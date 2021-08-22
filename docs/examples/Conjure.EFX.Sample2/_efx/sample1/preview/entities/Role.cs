using System;
using System.Collections.Generic;

namespace Tracker.Core.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Role'
    /// </summary>
    public partial class Role
    {
        public static string GetEntityClass() => "Role";
        public static string GetTableName() => "Role";

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        public Role()
        {
            #region Generated Constructor

            UserRoles = new HashSet<UserRole>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'Id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Id'.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Description'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Description'.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Created'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Created'.
        /// </value>
        public DateTimeOffset Created { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreatedBy'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreatedBy'.
        /// </value>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Updated'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Updated'.
        /// </value>
        public DateTimeOffset Updated { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UpdatedBy'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UpdatedBy'.
        /// </value>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RowVersion'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RowVersion'.
        /// </value>
        public Byte[] RowVersion { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="UserRole" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="UserRole" />.
        /// </value>
        public virtual ICollection<UserRole> UserRoles { get; set; }

        #endregion // Generated Relationships
    }
}
