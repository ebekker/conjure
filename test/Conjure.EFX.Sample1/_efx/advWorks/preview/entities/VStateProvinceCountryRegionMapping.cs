using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.VStateProvinceCountryRegion" />
    /// </summary>
    public partial class VStateProvinceCountryRegionMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.VStateProvinceCountryRegion>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.VStateProvinceCountryRegion" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.VStateProvinceCountryRegion> builder)
        {
            #region Generated Configure

            // table
            builder.ToView("vStateProvinceCountryRegion", "Person");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.StateProvinceID)
                .IsRequired()
                .HasColumnName("StateProvinceID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.StateProvinceCode)
                .IsRequired()
                .HasColumnName("StateProvinceCode")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.IsOnlyStateProvinceFlag)
                .IsRequired()
                .HasColumnName("IsOnlyStateProvinceFlag")
                .HasColumnType("bit")
                ;
            builder.Property(t => t.StateProvinceName)
                .IsRequired()
                .HasColumnName("StateProvinceName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.TerritoryID)
                .IsRequired()
                .HasColumnName("TerritoryID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.CountryRegionCode)
                .IsRequired()
                .HasColumnName("CountryRegionCode")
                .HasColumnType("nvarchar(3)")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.CountryRegionName)
                .IsRequired()
                .HasColumnName("CountryRegionName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;

            // relationships

            #endregion // Generated Configure
        }
    }
}
