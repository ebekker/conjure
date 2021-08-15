using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorksLT.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorksLT.Data.Entities.ProductCategory" />
    /// </summary>
    public partial class ProductCategoryMap
        : IEntityTypeConfiguration<AdvWorksLT.Data.Entities.ProductCategory>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorksLT.Data.Entities.ProductCategory" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorksLT.Data.Entities.ProductCategory> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ProductCategory", "SalesLT");

            // key
            builder.HasKey(t => t.ProductCategoryID);

            // properties
            builder.Property(t => t.ProductCategoryID)
                .IsRequired()
                .HasColumnName("ProductCategoryID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.ParentProductCategoryID)
                .HasColumnName("ParentProductCategoryID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
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
            builder.HasOne(t => t.ParentProductCategory)
                .WithMany(t => t.ParentProductCategories)
                .HasForeignKey(d => d.ParentProductCategoryID)
                .HasConstraintName("FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID")
                ;

            #endregion // Generated Configure
        }
    }
}
