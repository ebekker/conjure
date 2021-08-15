using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ShoppingCartItem" />
    /// </summary>
    public partial class ShoppingCartItemMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ShoppingCartItem>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ShoppingCartItem" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ShoppingCartItem> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ShoppingCartItem", "Sales");

            // key
            builder.HasKey(t => t.ShoppingCartItemID);

            // properties
            builder.Property(t => t.ShoppingCartItemID)
                .IsRequired()
                .HasColumnName("ShoppingCartItemID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.ShoppingCartID)
                .IsRequired()
                .HasColumnName("ShoppingCartID")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.Quantity)
                .IsRequired()
                .HasColumnName("Quantity")
                .HasColumnType("int")
                .HasDefaultValueSql("((1))")
                ;
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.DateCreated)
                .IsRequired()
                .HasColumnName("DateCreated")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.ShoppingCartItems)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_ShoppingCartItem_Product_ProductID")
                ;

            #endregion // Generated Configure
        }
    }
}
