using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.SalesTerritoryHistory" />
    /// </summary>
    public partial class SalesTerritoryHistoryMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.SalesTerritoryHistory>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.SalesTerritoryHistory" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.SalesTerritoryHistory> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("SalesTerritoryHistory", "Sales");

            // key
            builder.HasKey(t => new {
                t.BusinessEntityID,
                t.TerritoryID,
                t.StartDate
            });
            

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.TerritoryID)
                .IsRequired()
                .HasColumnName("TerritoryID")
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
                .WithMany(t => t.SalesTerritoryHistories)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID")
                ;
            builder.HasOne(t => t.SalesTerritory)
                .WithMany(t => t.SalesTerritoryHistories)
                .HasForeignKey(d => d.TerritoryID)
                .HasConstraintName("FK_SalesTerritoryHistory_SalesTerritory_TerritoryID")
                ;

            #endregion // Generated Configure
        }
    }
}
