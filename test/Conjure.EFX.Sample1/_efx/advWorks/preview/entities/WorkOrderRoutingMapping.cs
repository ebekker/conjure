using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.WorkOrderRouting" />
    /// </summary>
    public partial class WorkOrderRoutingMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.WorkOrderRouting>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.WorkOrderRouting" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.WorkOrderRouting> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("WorkOrderRouting", "Production");

            // key
            builder.HasKey(t => new {
                t.WorkOrderID,
                t.ProductID,
                t.OperationSequence
            });
            

            // properties
            builder.Property(t => t.WorkOrderID)
                .IsRequired()
                .HasColumnName("WorkOrderID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.OperationSequence)
                .IsRequired()
                .HasColumnName("OperationSequence")
                .HasColumnType("smallint")
                ;
            builder.Property(t => t.LocationID)
                .IsRequired()
                .HasColumnName("LocationID")
                .HasColumnType("smallint")
                ;
            builder.Property(t => t.ScheduledStartDate)
                .IsRequired()
                .HasColumnName("ScheduledStartDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.ScheduledEndDate)
                .IsRequired()
                .HasColumnName("ScheduledEndDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.ActualStartDate)
                .HasColumnName("ActualStartDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.ActualEndDate)
                .HasColumnName("ActualEndDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.ActualResourceHrs)
                .HasColumnName("ActualResourceHrs")
                .HasColumnType("decimal(9,4)")
                ;
            builder.Property(t => t.PlannedCost)
                .IsRequired()
                .HasColumnName("PlannedCost")
                .HasColumnType("money")
                ;
            builder.Property(t => t.ActualCost)
                .HasColumnName("ActualCost")
                .HasColumnType("money")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.Location)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.LocationID)
                .HasConstraintName("FK_WorkOrderRouting_Location_LocationID")
                ;
            builder.HasOne(t => t.WorkOrder)
                .WithMany(t => t.WorkOrderRoutings)
                .HasForeignKey(d => d.WorkOrderID)
                .HasConstraintName("FK_WorkOrderRouting_WorkOrder_WorkOrderID")
                ;

            #endregion // Generated Configure
        }
    }
}
