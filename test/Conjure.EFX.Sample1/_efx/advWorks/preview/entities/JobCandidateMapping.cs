using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.JobCandidate" />
    /// </summary>
    public partial class JobCandidateMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.JobCandidate>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.JobCandidate" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.JobCandidate> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("JobCandidate", "HumanResources");

            // key
            builder.HasKey(t => t.JobCandidateID);

            // properties
            builder.Property(t => t.JobCandidateID)
                .IsRequired()
                .HasColumnName("JobCandidateID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.BusinessEntityID)
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Resume)
                .HasColumnName("Resume")
                .HasColumnType("xml")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.JobCandidates)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_JobCandidate_Employee_BusinessEntityID")
                ;

            #endregion // Generated Configure
        }
    }
}
