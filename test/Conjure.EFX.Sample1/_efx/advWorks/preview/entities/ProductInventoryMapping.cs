using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ProductInventory" />
    /// </summary>
    public partial class ProductInventoryMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ProductInventory>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ProductInventory" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ProductInventory> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ProductInventory", "Production");

            // key
            builder.HasKey(t => new {
                t.ProductID,
                t.LocationID
            });
            

            // properties
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.LocationID)
                .IsRequired()
                .HasColumnName("LocationID")
                .HasColumnType("smallint")
                ;
            builder.Property(t => t.Shelf)
                .IsRequired()
                .HasColumnName("Shelf")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10)
                ;
            builder.Property(t => t.Bin)
                .IsRequired()
                .HasColumnName("Bin")
                .HasColumnType("tinyint")
                ;
            builder.Property(t => t.Quantity)
                .IsRequired()
                .HasColumnName("Quantity")
                .HasColumnType("smallint")
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
            builder.HasOne(t => t.Location)
                .WithMany(t => t.ProductInventories)
                .HasForeignKey(d => d.LocationID)
                .HasConstraintName("FK_ProductInventory_Location_LocationID")
                ;
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductInventories)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_ProductInventory_Product_ProductID")
                ;

            #endregion // Generated Configure
        }
    }
}
