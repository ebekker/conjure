using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorksLT.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorksLT.Data.Entities.ProductModelProductDescription" />
    /// </summary>
    public partial class ProductModelProductDescriptionMap
        : IEntityTypeConfiguration<AdvWorksLT.Data.Entities.ProductModelProductDescription>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorksLT.Data.Entities.ProductModelProductDescription" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorksLT.Data.Entities.ProductModelProductDescription> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ProductModelProductDescription", "SalesLT");

            // key
            builder.HasKey(t => new {
                t.ProductModelID,
                t.ProductDescriptionID,
                t.Culture
            });
            

            // properties
            builder.Property(t => t.ProductModelID)
                .IsRequired()
                .HasColumnName("ProductModelID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ProductDescriptionID)
                .IsRequired()
                .HasColumnName("ProductDescriptionID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Culture)
                .IsRequired()
                .HasColumnName("Culture")
                .HasColumnType("nchar(6)")
                .HasMaxLength(6)
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
            builder.HasOne(t => t.ProductDescription)
                .WithMany(t => t.ProductModelProductDescriptions)
                .HasForeignKey(d => d.ProductDescriptionID)
                .HasConstraintName("FK_ProductModelProductDescription_ProductDescription_ProductDescriptionID")
                ;
            builder.HasOne(t => t.ProductModel)
                .WithMany(t => t.ProductModelProductDescriptions)
                .HasForeignKey(d => d.ProductModelID)
                .HasConstraintName("FK_ProductModelProductDescription_ProductModel_ProductModelID")
                ;

            #endregion // Generated Configure
        }
    }
}
