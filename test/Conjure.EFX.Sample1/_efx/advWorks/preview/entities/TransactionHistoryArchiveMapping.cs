using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.TransactionHistoryArchive" />
    /// </summary>
    public partial class TransactionHistoryArchiveMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.TransactionHistoryArchive>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.TransactionHistoryArchive" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.TransactionHistoryArchive> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("TransactionHistoryArchive", "Production");

            // key
            builder.HasKey(t => t.TransactionID);

            // properties
            builder.Property(t => t.TransactionID)
                .IsRequired()
                .HasColumnName("TransactionID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ReferenceOrderID)
                .IsRequired()
                .HasColumnName("ReferenceOrderID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ReferenceOrderLineID)
                .IsRequired()
                .HasColumnName("ReferenceOrderLineID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.TransactionDate)
                .IsRequired()
                .HasColumnName("TransactionDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;
            builder.Property(t => t.TransactionType)
                .IsRequired()
                .HasColumnName("TransactionType")
                .HasColumnType("nchar(1)")
                .HasMaxLength(1)
                ;
            builder.Property(t => t.Quantity)
                .IsRequired()
                .HasColumnName("Quantity")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ActualCost)
                .IsRequired()
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

            #endregion // Generated Configure
        }
    }
}
