using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.SalesPersonQuotaHistory" />
    /// </summary>
    public partial class SalesPersonQuotaHistoryMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.SalesPersonQuotaHistory>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.SalesPersonQuotaHistory" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.SalesPersonQuotaHistory> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("SalesPersonQuotaHistory", "Sales");

            // key
            builder.HasKey(t => new {
                t.BusinessEntityID,
                t.QuotaDate
            });
            

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.QuotaDate)
                .IsRequired()
                .HasColumnName("QuotaDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.SalesQuota)
                .IsRequired()
                .HasColumnName("SalesQuota")
                .HasColumnType("money")
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
            builder.HasOne(t => t.SalesPerson)
                .WithMany(t => t.SalesPersonQuotaHistories)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID")
                ;

            #endregion // Generated Configure
        }
    }
}
