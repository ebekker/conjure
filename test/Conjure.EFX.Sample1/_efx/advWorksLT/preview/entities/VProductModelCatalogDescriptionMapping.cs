using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorksLT.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorksLT.Data.Entities.VProductModelCatalogDescription" />
    /// </summary>
    public partial class VProductModelCatalogDescriptionMap
        : IEntityTypeConfiguration<AdvWorksLT.Data.Entities.VProductModelCatalogDescription>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorksLT.Data.Entities.VProductModelCatalogDescription" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorksLT.Data.Entities.VProductModelCatalogDescription> builder)
        {
            #region Generated Configure

            // table
            builder.ToView("vProductModelCatalogDescription", "SalesLT");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.ProductModelID)
                .IsRequired()
                .HasColumnName("ProductModelID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.Summary)
                .HasColumnName("Summary")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.Manufacturer)
                .HasColumnName("Manufacturer")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.Copyright)
                .HasColumnName("Copyright")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30)
                ;
            builder.Property(t => t.ProductURL)
                .HasColumnName("ProductURL")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.WarrantyPeriod)
                .HasColumnName("WarrantyPeriod")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.WarrantyDescription)
                .HasColumnName("WarrantyDescription")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.NoOfYears)
                .HasColumnName("NoOfYears")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.MaintenanceDescription)
                .HasColumnName("MaintenanceDescription")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.Wheel)
                .HasColumnName("Wheel")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.Saddle)
                .HasColumnName("Saddle")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.Pedal)
                .HasColumnName("Pedal")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.BikeFrame)
                .HasColumnName("BikeFrame")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.Crankset)
                .HasColumnName("Crankset")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.PictureAngle)
                .HasColumnName("PictureAngle")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.PictureSize)
                .HasColumnName("PictureSize")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.ProductPhotoID)
                .HasColumnName("ProductPhotoID")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.Material)
                .HasColumnName("Material")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.Color)
                .HasColumnName("Color")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.ProductLine)
                .HasColumnName("ProductLine")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.Style)
                .HasColumnName("Style")
                .HasColumnType("nvarchar(256)")
                .HasMaxLength(256)
                ;
            builder.Property(t => t.RiderExperience)
                .HasColumnName("RiderExperience")
                .HasColumnType("nvarchar(1024)")
                .HasMaxLength(1024)
                ;
            builder.Property(t => t.Rowguid)
                .IsRequired()
                .HasColumnName("rowguid")
                .HasColumnType("uniqueidentifier")
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
