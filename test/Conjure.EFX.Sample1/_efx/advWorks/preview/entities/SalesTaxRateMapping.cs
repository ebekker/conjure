using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.SalesTaxRate" />
    /// </summary>
    public partial class SalesTaxRateMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.SalesTaxRate>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.SalesTaxRate" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.SalesTaxRate> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("SalesTaxRate", "Sales");

            // key
            builder.HasKey(t => t.SalesTaxRateID);

            // properties
            builder.Property(t => t.SalesTaxRateID)
                .IsRequired()
                .HasColumnName("SalesTaxRateID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.StateProvinceID)
                .IsRequired()
                .HasColumnName("StateProvinceID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.TaxType)
                .IsRequired()
                .HasColumnName("TaxType")
                .HasColumnType("tinyint")
                ;
            builder.Property(t => t.TaxRate)
                .IsRequired()
                .HasColumnName("TaxRate")
                .HasColumnType("smallmoney")
                .HasDefaultValueSql("((0.00))")
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
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
            builder.HasOne(t => t.StateProvince)
                .WithMany(t => t.SalesTaxRates)
                .HasForeignKey(d => d.StateProvinceID)
                .HasConstraintName("FK_SalesTaxRate_StateProvince_StateProvinceID")
                ;

            #endregion // Generated Configure
        }
    }
}
