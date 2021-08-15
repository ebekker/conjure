using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ProductListPriceHistory" />
    /// </summary>
    public partial class ProductListPriceHistoryMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ProductListPriceHistory>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ProductListPriceHistory" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ProductListPriceHistory> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ProductListPriceHistory", "Production");

            // key
            builder.HasKey(t => new {
                t.ProductID,
                t.StartDate
            });
            

            // properties
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.ListPrice)
                .IsRequired()
                .HasColumnName("ListPrice")
                .HasColumnType("money")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ProductListPriceHistories)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_ProductListPriceHistory_Product_ProductID")
                ;

            #endregion // Generated Configure
        }
    }
}
