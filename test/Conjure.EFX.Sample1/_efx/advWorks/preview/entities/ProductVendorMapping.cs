using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ProductVendor" />
    /// </summary>
    public partial class ProductVendorMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ProductVendor>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ProductVendor" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ProductVendor> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ProductVendor", "Purchasing");

            // key
            builder.HasKey(t => new {
                t.ProductID,
                t.BusinessEntityID
            });
            

            // properties
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.AverageLeadTime)
                .IsRequired()
                .HasColumnName("AverageLeadTime")
                .HasColumnType("int")
                ;
            builder.Property(t => t.StandardPrice)
                .IsRequired()
                .HasColumnName("StandardPrice")
                .HasColumnType("money")
                ;
            builder.Property(t => t.LastReceiptCost)
                .HasColumnName("LastReceiptCost")
                .HasColumnType("money")
                ;
            builder.Property(t => t.LastReceiptDate)
                .HasColumnName("LastReceiptDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.MinOrderQty)
                .IsRequired()
                .HasColumnName("MinOrderQty")
                .HasColumnType("int")
                ;
            builder.Property(t => t.MaxOrderQty)
                .IsRequired()
                .HasColumnName("MaxOrderQty")
                .HasColumnType("int")
                ;
            builder.Property(t => t.OnOrderQty)
                .HasColumnName("OnOrderQty")
                .HasColumnType("int")
                ;
            builder.Property(t => t.UnitMeasureCode)
                .IsRequired()
                .HasColumnName("UnitMeasureCode")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductVendors)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_ProductVendor_Product_ProductID")
                ;
            builder.HasOne(t => t.UnitMeasure)
                .WithMany(t => t.ProductVendors)
                .HasForeignKey(d => d.UnitMeasureCode)
                .HasConstraintName("FK_ProductVendor_UnitMeasure_UnitMeasureCode")
                ;
            builder.HasOne(t => t.Vendor)
                .WithMany(t => t.ProductVendors)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_ProductVendor_Vendor_BusinessEntityID")
                ;

            #endregion // Generated Configure
        }
    }
}
