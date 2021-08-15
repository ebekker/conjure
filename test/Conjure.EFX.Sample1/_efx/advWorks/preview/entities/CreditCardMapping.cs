using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.CreditCard" />
    /// </summary>
    public partial class CreditCardMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.CreditCard>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.CreditCard" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.CreditCard> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("CreditCard", "Sales");

            // key
            builder.HasKey(t => t.CreditCardID);

            // properties
            builder.Property(t => t.CreditCardID)
                .IsRequired()
                .HasColumnName("CreditCardID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.CardType)
                .IsRequired()
                .HasColumnName("CardType")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.CardNumber)
                .IsRequired()
                .HasColumnName("CardNumber")
                .HasColumnType("nvarchar(25)")
                .HasMaxLength(25)
                ;
            builder.Property(t => t.ExpMonth)
                .IsRequired()
                .HasColumnName("ExpMonth")
                .HasColumnType("tinyint")
                ;
            builder.Property(t => t.ExpYear)
                .IsRequired()
                .HasColumnName("ExpYear")
                .HasColumnType("smallint")
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
