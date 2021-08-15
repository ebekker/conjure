using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.VEmployeeDepartmentHistory" />
    /// </summary>
    public partial class VEmployeeDepartmentHistoryMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.VEmployeeDepartmentHistory>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.VEmployeeDepartmentHistory" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.VEmployeeDepartmentHistory> builder)
        {
            #region Generated Configure

            // table
            builder.ToView("vEmployeeDepartmentHistory", "HumanResources");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasColumnType("nvarchar(8)")
                .HasMaxLength(8)
                ;
            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.MiddleName)
                .HasColumnName("MiddleName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.Suffix)
                .HasColumnName("Suffix")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10)
                ;
            builder.Property(t => t.Shift)
                .IsRequired()
                .HasColumnName("Shift")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.Department)
                .IsRequired()
                .HasColumnName("Department")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.GroupName)
                .IsRequired()
                .HasColumnName("GroupName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
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

            // relationships

            #endregion // Generated Configure
        }
    }
}
