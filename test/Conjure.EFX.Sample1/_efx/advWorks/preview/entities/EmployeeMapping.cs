using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.Employee" />
    /// </summary>
    public partial class EmployeeMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.Employee>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.Employee" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.Employee> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("Employee", "HumanResources");

            // key
            builder.HasKey(t => t.BusinessEntityID);

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.NationalIDNumber)
                .IsRequired()
                .HasColumnName("NationalIDNumber")
                .HasColumnType("nvarchar(15)")
                .HasMaxLength(15)
                ;
            builder.Property(t => t.LoginID)
                .IsRequired()
                .HasColumnName("LoginID")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.OrganizationLevel)
                .HasColumnName("OrganizationLevel")
                .HasColumnType("smallint")
                .ValueGeneratedOnAddOrUpdate()
                ;
            builder.Property(t => t.JobTitle)
                .IsRequired()
                .HasColumnName("JobTitle")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.BirthDate)
                .IsRequired()
                .HasColumnName("BirthDate")
                .HasColumnType("date")
                ;
            builder.Property(t => t.MaritalStatus)
                .IsRequired()
                .HasColumnName("MaritalStatus")
                .HasColumnType("nchar(1)")
                .HasMaxLength(1)
                ;
            builder.Property(t => t.Gender)
                .IsRequired()
                .HasColumnName("Gender")
                .HasColumnType("nchar(1)")
                .HasMaxLength(1)
                ;
            builder.Property(t => t.HireDate)
                .IsRequired()
                .HasColumnName("HireDate")
                .HasColumnType("date")
                ;
            builder.Property(t => t.SalariedFlag)
                .IsRequired()
                .HasColumnName("SalariedFlag")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))")
                ;
            builder.Property(t => t.VacationHours)
                .IsRequired()
                .HasColumnName("VacationHours")
                .HasColumnType("smallint")
                ;
            builder.Property(t => t.SickLeaveHours)
                .IsRequired()
                .HasColumnName("SickLeaveHours")
                .HasColumnType("smallint")
                ;
            builder.Property(t => t.CurrentFlag)
                .IsRequired()
                .HasColumnName("CurrentFlag")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))")
                ;
            builder.Property(t => t.Rowguid)
                .IsRequired()
                .HasColumnName("rowguid")
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("(newid())")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.Person)
                .WithOne(t => t.Employee)
                .HasForeignKey<AdvWorks.Data.Entities.Employee>(d => d.BusinessEntityID)
                .HasConstraintName("FK_Employee_Person_BusinessEntityID")
                ;

            #endregion // Generated Configure
        }
    }
}
