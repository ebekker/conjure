using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.SalesOrderHeaderSalesReason" />
    /// </summary>
    public partial class SalesOrderHeaderSalesReasonMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.SalesOrderHeaderSalesReason>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.SalesOrderHeaderSalesReason" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.SalesOrderHeaderSalesReason> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("SalesOrderHeaderSalesReason", "Sales");

            // key
            builder.HasKey(t => new {
                t.SalesOrderID,
                t.SalesReasonID
            });
            

            // properties
            builder.Property(t => t.SalesOrderID)
                .IsRequired()
                .HasColumnName("SalesOrderID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.SalesReasonID)
                .IsRequired()
                .HasColumnName("SalesReasonID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.SalesOrderHeader)
                .WithMany(t => t.SalesOrderHeaderSalesReasons)
                .HasForeignKey(d => d.SalesOrderID)
                .HasConstraintName("FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID")
                ;
            builder.HasOne(t => t.SalesReason)
                .WithMany(t => t.SalesOrderHeaderSalesReasons)
                .HasForeignKey(d => d.SalesReasonID)
                .HasConstraintName("FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID")
                ;

            #endregion // Generated Configure
        }
    }
}
