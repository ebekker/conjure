using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorksLT.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorksLT.Data.Entities.SalesOrderDetail" />
    /// </summary>
    public partial class SalesOrderDetailMap
        : IEntityTypeConfiguration<AdvWorksLT.Data.Entities.SalesOrderDetail>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorksLT.Data.Entities.SalesOrderDetail" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorksLT.Data.Entities.SalesOrderDetail> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("SalesOrderDetail", "SalesLT");

            // key
            builder.HasKey(t => new {
                t.SalesOrderID,
                t.SalesOrderDetailID
            });
            

            // properties
            builder.Property(t => t.SalesOrderID)
                .IsRequired()
                .HasColumnName("SalesOrderID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.SalesOrderDetailID)
                .IsRequired()
                .HasColumnName("SalesOrderDetailID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.OrderQty)
                .IsRequired()
                .HasColumnName("OrderQty")
                .HasColumnType("smallint")
                ;
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.UnitPrice)
                .IsRequired()
                .HasColumnName("UnitPrice")
                .HasColumnType("money")
                ;
            builder.Property(t => t.UnitPriceDiscount)
                .IsRequired()
                .HasColumnName("UnitPriceDiscount")
                .HasColumnType("money")
                ;
            builder.Property(t => t.LineTotal)
                .IsRequired()
                .HasColumnName("LineTotal")
                .HasColumnType("numeric(38,6)")
                .ValueGeneratedOnAddOrUpdate()
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
                .WithMany(t => t.SalesOrderDetails)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_SalesOrderDetail_Product_ProductID")
                ;
            builder.HasOne(t => t.SalesOrderHeader)
                .WithMany(t => t.SalesOrderDetails)
                .HasForeignKey(d => d.SalesOrderID)
                .HasConstraintName("FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID")
                ;

            #endregion // Generated Configure
        }
    }
}
