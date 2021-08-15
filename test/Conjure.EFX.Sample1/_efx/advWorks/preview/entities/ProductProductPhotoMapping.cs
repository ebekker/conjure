using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ProductProductPhoto" />
    /// </summary>
    public partial class ProductProductPhotoMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ProductProductPhoto>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ProductProductPhoto" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ProductProductPhoto> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ProductProductPhoto", "Production");

            // key
            builder.HasKey(t => new {
                t.ProductID,
                t.ProductPhotoID
            });
            

            // properties
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ProductPhotoID)
                .IsRequired()
                .HasColumnName("ProductPhotoID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Primary)
                .IsRequired()
                .HasColumnName("Primary")
                .HasColumnType("bit")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductProductPhotos)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_ProductProductPhoto_Product_ProductID")
                ;
            builder.HasOne(t => t.ProductPhoto)
                .WithMany(t => t.ProductProductPhotos)
                .HasForeignKey(d => d.ProductPhotoID)
                .HasConstraintName("FK_ProductProductPhoto_ProductPhoto_ProductPhotoID")
                ;

            #endregion // Generated Configure
        }
    }
}
