using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.StateProvince" />
    /// </summary>
    public partial class StateProvinceMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.StateProvince>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.StateProvince" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.StateProvince> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("StateProvince", "Person");

            // key
            builder.HasKey(t => t.StateProvinceID);

            // properties
            builder.Property(t => t.StateProvinceID)
                .IsRequired()
                .HasColumnName("StateProvinceID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.StateProvinceCode)
                .IsRequired()
                .HasColumnName("StateProvinceCode")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.CountryRegionCode)
                .IsRequired()
                .HasColumnName("CountryRegionCode")
                .HasColumnType("nvarchar(3)")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.IsOnlyStateProvinceFlag)
                .IsRequired()
                .HasColumnName("IsOnlyStateProvinceFlag")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))")
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.TerritoryID)
                .IsRequired()
                .HasColumnName("TerritoryID")
                .HasColumnType("int")
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
            builder.HasOne(t => t.CountryRegion)
                .WithMany(t => t.StateProvinces)
                .HasForeignKey(d => d.CountryRegionCode)
                .HasConstraintName("FK_StateProvince_CountryRegion_CountryRegionCode")
                ;
            builder.HasOne(t => t.SalesTerritory)
                .WithMany(t => t.StateProvinces)
                .HasForeignKey(d => d.TerritoryID)
                .HasConstraintName("FK_StateProvince_SalesTerritory_TerritoryID")
                ;

            #endregion // Generated Configure
        }
    }
}
