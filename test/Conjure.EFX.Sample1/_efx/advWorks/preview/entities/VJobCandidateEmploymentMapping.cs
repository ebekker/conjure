using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.VJobCandidateEmployment" />
    /// </summary>
    public partial class VJobCandidateEmploymentMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.VJobCandidateEmployment>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.VJobCandidateEmployment" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.VJobCandidateEmployment> builder)
        {
            #region Generated Configure

            // table
            builder.ToView("vJobCandidateEmployment", "HumanResources");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.JobCandidateID)
                .IsRequired()
                .HasColumnName("JobCandidateID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.EmpStartDate)
                .HasColumnName("Emp.StartDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.EmpEndDate)
                .HasColumnName("Emp.EndDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.EmpOrgName)
                .HasColumnName("Emp.OrgName")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                ;
            builder.Property(t => t.EmpJobTitle)
                .HasColumnName("Emp.JobTitle")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                ;
            builder.Property(t => t.EmpResponsibility)
                .HasColumnName("Emp.Responsibility")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.EmpFunctionCategory)
                .HasColumnName("Emp.FunctionCategory")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.EmpIndustryCategory)
                .HasColumnName("Emp.IndustryCategory")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.EmpLocCountryRegion)
                .HasColumnName("Emp.Loc.CountryRegion")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.EmpLocState)
                .HasColumnName("Emp.Loc.State")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.EmpLocCity)
                .HasColumnName("Emp.Loc.City")
                .HasColumnType("nvarchar(max)")
                ;

            // relationships

            #endregion // Generated Configure
        }
    }
}
