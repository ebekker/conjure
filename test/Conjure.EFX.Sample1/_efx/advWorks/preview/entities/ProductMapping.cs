using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.Product" />
    /// </summary>
    public partial class ProductMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.Product>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.Product" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.Product> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("Product", "Production");

            // key
            builder.HasKey(t => t.ProductID);

            // properties
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.ProductNumber)
                .IsRequired()
                .HasColumnName("ProductNumber")
                .HasColumnType("nvarchar(25)")
                .HasMaxLength(25)
                ;
            builder.Property(t => t.MakeFlag)
                .IsRequired()
                .HasColumnName("MakeFlag")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))")
                ;
            builder.Property(t => t.FinishedGoodsFlag)
                .IsRequired()
                .HasColumnName("FinishedGoodsFlag")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))")
                ;
            builder.Property(t => t.Color)
                .HasColumnName("Color")
                .HasColumnType("nvarchar(15)")
                .HasMaxLength(15)
                ;
            builder.Property(t => t.SafetyStockLevel)
                .IsRequired()
                .HasColumnName("SafetyStockLevel")
                .HasColumnType("smallint")
                ;
            builder.Property(t => t.ReorderPoint)
                .IsRequired()
                .HasColumnName("ReorderPoint")
                .HasColumnType("smallint")
                ;
            builder.Property(t => t.StandardCost)
                .IsRequired()
                .HasColumnName("StandardCost")
                .HasColumnType("money")
                ;
            builder.Property(t => t.ListPrice)
                .IsRequired()
                .HasColumnName("ListPrice")
                .HasColumnType("money")
                ;
            builder.Property(t => t.Size)
                .HasColumnName("Size")
                .HasColumnType("nvarchar(5)")
                .HasMaxLength(5)
                ;
            builder.Property(t => t.SizeUnitMeasureCode)
                .HasColumnName("SizeUnitMeasureCode")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.WeightUnitMeasureCode)
                .HasColumnName("WeightUnitMeasureCode")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.Weight)
                .HasColumnName("Weight")
                .HasColumnType("decimal(8,2)")
                ;
            builder.Property(t => t.DaysToManufacture)
                .IsRequired()
                .HasColumnName("DaysToManufacture")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ProductLine)
                .HasColumnName("ProductLine")
                .HasColumnType("nchar(2)")
                .HasMaxLength(2)
                ;
            builder.Property(t => t.Class)
                .HasColumnName("Class")
                .HasColumnType("nchar(2)")
                .HasMaxLength(2)
                ;
            builder.Property(t => t.Style)
                .HasColumnName("Style")
                .HasColumnType("nchar(2)")
                .HasMaxLength(2)
                ;
            builder.Property(t => t.ProductSubcategoryID)
                .HasColumnName("ProductSubcategoryID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ProductModelID)
                .HasColumnName("ProductModelID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.SellStartDate)
                .IsRequired()
                .HasColumnName("SellStartDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.SellEndDate)
                .HasColumnName("SellEndDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.DiscontinuedDate)
                .HasColumnName("DiscontinuedDate")
                .HasColumnType("datetime")
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
            builder.HasOne(t => t.ProductModel)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.ProductModelID)
                .HasConstraintName("FK_Product_ProductModel_ProductModelID")
                ;
            builder.HasOne(t => t.ProductSubcategory)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.ProductSubcategoryID)
                .HasConstraintName("FK_Product_ProductSubcategory_ProductSubcategoryID")
                ;
            builder.HasOne(t => t.SizeUnitMeasure)
                .WithMany(t => t.SizeProducts)
                .HasForeignKey(d => d.SizeUnitMeasureCode)
                .HasConstraintName("FK_Product_UnitMeasure_SizeUnitMeasureCode")
                ;
            builder.HasOne(t => t.WeightUnitMeasure)
                .WithMany(t => t.WeightProducts)
                .HasForeignKey(d => d.WeightUnitMeasureCode)
                .HasConstraintName("FK_Product_UnitMeasure_WeightUnitMeasureCode")
                ;

            #endregion // Generated Configure
        }
    }
}
