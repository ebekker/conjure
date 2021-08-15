using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ProductReview" />
    /// </summary>
    public partial class ProductReviewMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ProductReview>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ProductReview" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ProductReview> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ProductReview", "Production");

            // key
            builder.HasKey(t => t.ProductReviewID);

            // properties
            builder.Property(t => t.ProductReviewID)
                .IsRequired()
                .HasColumnName("ProductReviewID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ReviewerName)
                .IsRequired()
                .HasColumnName("ReviewerName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.ReviewDate)
                .IsRequired()
                .HasColumnName("ReviewDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;
            builder.Property(t => t.EmailAddress)
                .IsRequired()
                .HasColumnName("EmailAddress")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.Rating)
                .IsRequired()
                .HasColumnName("Rating")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Comments)
                .HasColumnName("Comments")
                .HasColumnType("nvarchar(3850)")
                .HasMaxLength(3850)
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductReviews)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_ProductReview_Product_ProductID")
                ;

            #endregion // Generated Configure
        }
    }
}
