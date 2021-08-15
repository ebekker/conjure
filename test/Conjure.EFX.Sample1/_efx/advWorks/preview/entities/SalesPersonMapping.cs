using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.SalesPerson" />
    /// </summary>
    public partial class SalesPersonMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.SalesPerson>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.SalesPerson" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.SalesPerson> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("SalesPerson", "Sales");

            // key
            builder.HasKey(t => t.BusinessEntityID);

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.TerritoryID)
                .HasColumnName("TerritoryID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.SalesQuota)
                .HasColumnName("SalesQuota")
                .HasColumnType("money")
                ;
            builder.Property(t => t.Bonus)
                .IsRequired()
                .HasColumnName("Bonus")
                .HasColumnType("money")
                .HasDefaultValueSql("((0.00))")
                ;
            builder.Property(t => t.CommissionPct)
                .IsRequired()
                .HasColumnName("CommissionPct")
                .HasColumnType("smallmoney")
                .HasDefaultValueSql("((0.00))")
                ;
            builder.Property(t => t.SalesYTD)
                .IsRequired()
                .HasColumnName("SalesYTD")
                .HasColumnType("money")
                .HasDefaultValueSql("((0.00))")
                ;
            builder.Property(t => t.SalesLastYear)
                .IsRequired()
                .HasColumnName("SalesLastYear")
                .HasColumnType("money")
                .HasDefaultValueSql("((0.00))")
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
            builder.HasOne(t => t.Employee)
                .WithOne(t => t.SalesPerson)
                .HasForeignKey<AdvWorks.Data.Entities.SalesPerson>(d => d.BusinessEntityID)
                .HasConstraintName("FK_SalesPerson_Employee_BusinessEntityID")
                ;
            builder.HasOne(t => t.SalesTerritory)
                .WithMany(t => t.SalesPeople)
                .HasForeignKey(d => d.TerritoryID)
                .HasConstraintName("FK_SalesPerson_SalesTerritory_TerritoryID")
                ;

            #endregion // Generated Configure
        }
    }
}
