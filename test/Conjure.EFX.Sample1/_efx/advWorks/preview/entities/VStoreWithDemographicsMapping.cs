using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.VStoreWithDemographics" />
    /// </summary>
    public partial class VStoreWithDemographicsMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.VStoreWithDemographics>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.VStoreWithDemographics" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.VStoreWithDemographics> builder)
        {
            #region Generated Configure

            // table
            builder.ToView("vStoreWithDemographics", "Sales");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.AnnualSales)
                .HasColumnName("AnnualSales")
                .HasColumnType("money")
                ;
            builder.Property(t => t.AnnualRevenue)
                .HasColumnName("AnnualRevenue")
                .HasColumnType("money")
                ;
            builder.Property(t => t.BankName)
                .HasColumnName("BankName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.BusinessType)
                .HasColumnName("BusinessType")
                .HasColumnType("nvarchar(5)")
                .HasMaxLength(5)
                ;
            builder.Property(t => t.YearOpened)
                .HasColumnName("YearOpened")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Specialty)
                .HasColumnName("Specialty")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.SquareFeet)
                .HasColumnName("SquareFeet")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Brands)
                .HasColumnName("Brands")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30)
                ;
            builder.Property(t => t.Internet)
                .HasColumnName("Internet")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30)
                ;
            builder.Property(t => t.NumberEmployees)
                .HasColumnName("NumberEmployees")
                .HasColumnType("int")
                ;

            // relationships

            #endregion // Generated Configure
        }
    }
}
