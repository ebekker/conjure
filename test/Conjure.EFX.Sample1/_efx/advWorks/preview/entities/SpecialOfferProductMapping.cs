using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.SpecialOfferProduct" />
    /// </summary>
    public partial class SpecialOfferProductMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.SpecialOfferProduct>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.SpecialOfferProduct" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.SpecialOfferProduct> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("SpecialOfferProduct", "Sales");

            // key
            builder.HasKey(t => new {
                t.SpecialOfferID,
                t.ProductID
            });
            

            // properties
            builder.Property(t => t.SpecialOfferID)
                .IsRequired()
                .HasColumnName("SpecialOfferID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int")
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
            builder.HasOne(t => t.Product)
                .WithMany(t => t.SpecialOfferProducts)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_SpecialOfferProduct_Product_ProductID")
                ;
            builder.HasOne(t => t.SpecialOffer)
                .WithMany(t => t.SpecialOfferProducts)
                .HasForeignKey(d => d.SpecialOfferID)
                .HasConstraintName("FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID")
                ;

            #endregion // Generated Configure
        }
    }
}
