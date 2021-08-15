using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.VSalesPersonSalesByFiscalYears" />
    /// </summary>
    public partial class VSalesPersonSalesByFiscalYearsMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.VSalesPersonSalesByFiscalYears>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.VSalesPersonSalesByFiscalYears" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.VSalesPersonSalesByFiscalYears> builder)
        {
            #region Generated Configure

            // table
            builder.ToView("vSalesPersonSalesByFiscalYears", "Sales");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.SalesPersonID)
                .HasColumnName("SalesPersonID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.FullName)
                .HasColumnName("FullName")
                .HasColumnType("nvarchar(152)")
                .HasMaxLength(152)
                ;
            builder.Property(t => t.JobTitle)
                .IsRequired()
                .HasColumnName("JobTitle")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.SalesTerritory)
                .IsRequired()
                .HasColumnName("SalesTerritory")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.Number2002)
                .HasColumnName("2002")
                .HasColumnType("money")
                ;
            builder.Property(t => t.Number2003)
                .HasColumnName("2003")
                .HasColumnType("money")
                ;
            builder.Property(t => t.Number2004)
                .HasColumnName("2004")
                .HasColumnType("money")
                ;

            // relationships

            #endregion // Generated Configure
        }
    }
}
