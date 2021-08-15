using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ProductSubcategory" />
    /// </summary>
    public partial class ProductSubcategoryMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ProductSubcategory>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ProductSubcategory" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ProductSubcategory> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ProductSubcategory", "Production");

            // key
            builder.HasKey(t => t.ProductSubcategoryID);

            // properties
            builder.Property(t => t.ProductSubcategoryID)
                .IsRequired()
                .HasColumnName("ProductSubcategoryID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.ProductCategoryID)
                .IsRequired()
                .HasColumnName("ProductCategoryID")
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
            builder.HasOne(t => t.ProductCategory)
                .WithMany(t => t.ProductSubcategories)
                .HasForeignKey(d => d.ProductCategoryID)
                .HasConstraintName("FK_ProductSubcategory_ProductCategory_ProductCategoryID")
                ;

            #endregion // Generated Configure
        }
    }
}
