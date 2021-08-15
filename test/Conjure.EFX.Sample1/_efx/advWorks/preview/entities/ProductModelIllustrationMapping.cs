using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ProductModelIllustration" />
    /// </summary>
    public partial class ProductModelIllustrationMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ProductModelIllustration>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ProductModelIllustration" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ProductModelIllustration> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ProductModelIllustration", "Production");

            // key
            builder.HasKey(t => new {
                t.ProductModelID,
                t.IllustrationID
            });
            

            // properties
            builder.Property(t => t.ProductModelID)
                .IsRequired()
                .HasColumnName("ProductModelID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.IllustrationID)
                .IsRequired()
                .HasColumnName("IllustrationID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.Illustration)
                .WithMany(t => t.ProductModelIllustrations)
                .HasForeignKey(d => d.IllustrationID)
                .HasConstraintName("FK_ProductModelIllustration_Illustration_IllustrationID")
                ;
            builder.HasOne(t => t.ProductModel)
                .WithMany(t => t.ProductModelIllustrations)
                .HasForeignKey(d => d.ProductModelID)
                .HasConstraintName("FK_ProductModelIllustration_ProductModel_ProductModelID")
                ;

            #endregion // Generated Configure
        }
    }
}
