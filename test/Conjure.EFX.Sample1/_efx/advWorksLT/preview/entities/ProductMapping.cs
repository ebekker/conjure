using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorksLT.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorksLT.Data.Entities.Product" />
    /// </summary>
    public partial class ProductMap
        : IEntityTypeConfiguration<AdvWorksLT.Data.Entities.Product>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorksLT.Data.Entities.Product" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorksLT.Data.Entities.Product> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("Product", "SalesLT");

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
            builder.Property(t => t.Color)
                .HasColumnName("Color")
                .HasColumnType("nvarchar(15)")
                .HasMaxLength(15)
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
            builder.Property(t => t.Weight)
                .HasColumnName("Weight")
                .HasColumnType("decimal(8,2)")
                ;
            builder.Property(t => t.ProductCategoryID)
                .HasColumnName("ProductCategoryID")
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
            builder.Property(t => t.ThumbNailPhoto)
                .HasColumnName("ThumbNailPhoto")
                .HasColumnType("varbinary(max)")
                ;
            builder.Property(t => t.ThumbnailPhotoFileName)
                .HasColumnName("ThumbnailPhotoFileName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
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
            builder.HasOne(t => t.ProductCategory)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.ProductCategoryID)
                .HasConstraintName("FK_Product_ProductCategory_ProductCategoryID")
                ;
            builder.HasOne(t => t.ProductModel)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.ProductModelID)
                .HasConstraintName("FK_Product_ProductModel_ProductModelID")
                ;

            #endregion // Generated Configure
        }
    }
}
