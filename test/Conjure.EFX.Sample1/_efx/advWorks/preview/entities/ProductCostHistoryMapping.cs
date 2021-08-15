using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ProductCostHistory" />
    /// </summary>
    public partial class ProductCostHistoryMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ProductCostHistory>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ProductCostHistory" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ProductCostHistory> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ProductCostHistory", "Production");

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
            builder.Property(t => t.StandardCost)
                .IsRequired()
                .HasColumnName("StandardCost")
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
                .WithMany(t => t.ProductCostHistories)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_ProductCostHistory_Product_ProductID")
                ;

            #endregion // Generated Configure
        }
    }
}
