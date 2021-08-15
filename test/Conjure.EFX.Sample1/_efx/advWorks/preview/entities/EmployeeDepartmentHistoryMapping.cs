using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.EmployeeDepartmentHistory" />
    /// </summary>
    public partial class EmployeeDepartmentHistoryMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.EmployeeDepartmentHistory>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.EmployeeDepartmentHistory" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.EmployeeDepartmentHistory> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("EmployeeDepartmentHistory", "HumanResources");

            // key
            builder.HasKey(t => new {
                t.BusinessEntityID,
                t.DepartmentID,
                t.ShiftID,
                t.StartDate
            });
            

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.DepartmentID)
                .IsRequired()
                .HasColumnName("DepartmentID")
                .HasColumnType("smallint")
                ;
            builder.Property(t => t.ShiftID)
                .IsRequired()
                .HasColumnName("ShiftID")
                .HasColumnType("tinyint")
                ;
            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("date")
                ;
            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("date")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.Department)
                .WithMany(t => t.EmployeeDepartmentHistories)
                .HasForeignKey(d => d.DepartmentID)
                .HasConstraintName("FK_EmployeeDepartmentHistory_Department_DepartmentID")
                ;
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.EmployeeDepartmentHistories)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_EmployeeDepartmentHistory_Employee_BusinessEntityID")
                ;
            builder.HasOne(t => t.Shift)
                .WithMany(t => t.EmployeeDepartmentHistories)
                .HasForeignKey(d => d.ShiftID)
                .HasConstraintName("FK_EmployeeDepartmentHistory_Shift_ShiftID")
                ;

            #endregion // Generated Configure
        }
    }
}
