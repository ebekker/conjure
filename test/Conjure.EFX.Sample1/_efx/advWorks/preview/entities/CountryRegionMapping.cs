using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.CountryRegion" />
    /// </summary>
    public partial class CountryRegionMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.CountryRegion>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.CountryRegion" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.CountryRegion> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("CountryRegion", "Person");

            // key
            builder.HasKey(t => t.CountryRegionCode);

            // properties
            builder.Property(t => t.CountryRegionCode)
                .IsRequired()
                .HasColumnName("CountryRegionCode")
                .HasColumnType("nvarchar(3)")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
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
