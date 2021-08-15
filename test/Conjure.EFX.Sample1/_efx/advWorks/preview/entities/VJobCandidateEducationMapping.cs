using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.VJobCandidateEducation" />
    /// </summary>
    public partial class VJobCandidateEducationMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.VJobCandidateEducation>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.VJobCandidateEducation" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.VJobCandidateEducation> builder)
        {
            #region Generated Configure

            // table
            builder.ToView("vJobCandidateEducation", "HumanResources");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.JobCandidateID)
                .IsRequired()
                .HasColumnName("JobCandidateID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.EduLevel)
                .HasColumnName("Edu.Level")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.EduStartDate)
                .HasColumnName("Edu.StartDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.EduEndDate)
                .HasColumnName("Edu.EndDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.EduDegree)
                .HasColumnName("Edu.Degree")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.EduMajor)
                .HasColumnName("Edu.Major")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.EduMinor)
                .HasColumnName("Edu.Minor")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.EduGPA)
                .HasColumnName("Edu.GPA")
                .HasColumnType("nvarchar(5)")
                .HasMaxLength(5)
                ;
            builder.Property(t => t.EduGPAScale)
                .HasColumnName("Edu.GPAScale")
                .HasColumnType("nvarchar(5)")
                .HasMaxLength(5)
                ;
            builder.Property(t => t.EduSchool)
                .HasColumnName("Edu.School")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                ;
            builder.Property(t => t.EduLocCountryRegion)
                .HasColumnName("Edu.Loc.CountryRegion")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                ;
            builder.Property(t => t.EduLocState)
                .HasColumnName("Edu.Loc.State")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                ;
            builder.Property(t => t.EduLocCity)
                .HasColumnName("Edu.Loc.City")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                ;

            // relationships

            #endregion // Generated Configure
        }
    }
}
