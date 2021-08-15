using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.Department" />
    /// </summary>
    public partial class DepartmentMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.Department>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.Department" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.Department> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("Department", "HumanResources");

            // key
            builder.HasKey(t => t.DepartmentID);

            // properties
            builder.Property(t => t.DepartmentID)
                .IsRequired()
                .HasColumnName("DepartmentID")
                .HasColumnType("smallint")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.GroupName)
                .IsRequired()
                .HasColumnName("GroupName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships

            #endregion // Generated Configure
        }
    }
}
