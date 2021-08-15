using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.Currency" />
    /// </summary>
    public partial class CurrencyMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.Currency>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.Currency" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.Currency> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("Currency", "Sales");

            // key
            builder.HasKey(t => t.CurrencyCode);

            // properties
            builder.Property(t => t.CurrencyCode)
                .IsRequired()
                .HasColumnName("CurrencyCode")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
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
