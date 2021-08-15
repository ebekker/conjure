using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.CurrencyRate" />
    /// </summary>
    public partial class CurrencyRateMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.CurrencyRate>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.CurrencyRate" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.CurrencyRate> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("CurrencyRate", "Sales");

            // key
            builder.HasKey(t => t.CurrencyRateID);

            // properties
            builder.Property(t => t.CurrencyRateID)
                .IsRequired()
                .HasColumnName("CurrencyRateID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.CurrencyRateDate)
                .IsRequired()
                .HasColumnName("CurrencyRateDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.FromCurrencyCode)
                .IsRequired()
                .HasColumnName("FromCurrencyCode")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.ToCurrencyCode)
                .IsRequired()
                .HasColumnName("ToCurrencyCode")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.AverageRate)
                .IsRequired()
                .HasColumnName("AverageRate")
                .HasColumnType("money")
                ;
            builder.Property(t => t.EndOfDayRate)
                .IsRequired()
                .HasColumnName("EndOfDayRate")
                .HasColumnType("money")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.FromCurrency)
                .WithMany(t => t.FromCurrencyRates)
                .HasForeignKey(d => d.FromCurrencyCode)
                .HasConstraintName("FK_CurrencyRate_Currency_FromCurrencyCode")
                ;
            builder.HasOne(t => t.ToCurrency)
                .WithMany(t => t.ToCurrencyRates)
                .HasForeignKey(d => d.ToCurrencyCode)
                .HasConstraintName("FK_CurrencyRate_Currency_ToCurrencyCode")
                ;

            #endregion // Generated Configure
        }
    }
}
