using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.VJobCandidate" />
    /// </summary>
    public partial class VJobCandidateMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.VJobCandidate>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.VJobCandidate" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.VJobCandidate> builder)
        {
            #region Generated Configure

            // table
            builder.ToView("vJobCandidate", "HumanResources");

            // key
            builder.HasNoKey();

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
            builder.Property(t => t.NamePrefix)
                .HasColumnName("Name.Prefix")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30)
                ;
            builder.Property(t => t.NameFirst)
                .HasColumnName("Name.First")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30)
                ;
            builder.Property(t => t.NameMiddle)
                .HasColumnName("Name.Middle")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30)
                ;
            builder.Property(t => t.NameLast)
                .HasColumnName("Name.Last")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30)
                ;
            builder.Property(t => t.NameSuffix)
                .HasColumnName("Name.Suffix")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30)
                ;
            builder.Property(t => t.Skills)
                .HasColumnName("Skills")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.AddrType)
                .HasColumnName("Addr.Type")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30)
                ;
            builder.Property(t => t.AddrLocCountryRegion)
                .HasColumnName("Addr.Loc.CountryRegion")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                ;
            builder.Property(t => t.AddrLocState)
                .HasColumnName("Addr.Loc.State")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                ;
            builder.Property(t => t.AddrLocCity)
                .HasColumnName("Addr.Loc.City")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                ;
            builder.Property(t => t.AddrPostalCode)
                .HasColumnName("Addr.PostalCode")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20)
                ;
            builder.Property(t => t.EMail)
                .HasColumnName("EMail")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.WebSite)
                .HasColumnName("WebSite")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                ;

            // relationships

            #endregion // Generated Configure
        }
    }
}
