using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.WorkOrder" />
    /// </summary>
    public partial class WorkOrderMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.WorkOrder>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.WorkOrder" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.WorkOrder> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("WorkOrder", "Production");

            // key
            builder.HasKey(t => t.WorkOrderID);

            // properties
            builder.Property(t => t.WorkOrderID)
                .IsRequired()
                .HasColumnName("WorkOrderID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.OrderQty)
                .IsRequired()
                .HasColumnName("OrderQty")
                .HasColumnType("int")
                ;
            builder.Property(t => t.StockedQty)
                .IsRequired()
                .HasColumnName("StockedQty")
                .HasColumnType("int")
                .ValueGeneratedOnAddOrUpdate()
                ;
            builder.Property(t => t.ScrappedQty)
                .IsRequired()
                .HasColumnName("ScrappedQty")
                .HasColumnType("smallint")
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
            builder.Property(t => t.DueDate)
                .IsRequired()
                .HasColumnName("DueDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.ScrapReasonID)
                .HasColumnName("ScrapReasonID")
                .HasColumnType("smallint")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.Product)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_WorkOrder_Product_ProductID")
                ;
            builder.HasOne(t => t.ScrapReason)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.ScrapReasonID)
                .HasConstraintName("FK_WorkOrder_ScrapReason_ScrapReasonID")
                ;

            #endregion // Generated Configure
        }
    }
}
