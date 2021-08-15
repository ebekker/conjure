using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorksLT.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorksLT.Data.Entities.BuildVersion" />
    /// </summary>
    public partial class BuildVersionMap
        : IEntityTypeConfiguration<AdvWorksLT.Data.Entities.BuildVersion>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorksLT.Data.Entities.BuildVersion" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorksLT.Data.Entities.BuildVersion> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("BuildVersion", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.SystemInformationID)
                .IsRequired()
                .HasColumnName("SystemInformationID")
                .HasColumnType("tinyint")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.DatabaseVersion)
                .IsRequired()
                .HasColumnName("Database Version")
                .HasColumnType("nvarchar(25)")
                .HasMaxLength(25)
                ;
            builder.Property(t => t.VersionDate)
                .IsRequired()
                .HasColumnName("VersionDate")
                .HasColumnType("datetime")
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
