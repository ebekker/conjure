using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.PersonCreditCard" />
    /// </summary>
    public partial class PersonCreditCardMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.PersonCreditCard>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.PersonCreditCard" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.PersonCreditCard> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("PersonCreditCard", "Sales");

            // key
            builder.HasKey(t => new {
                t.BusinessEntityID,
                t.CreditCardID
            });
            

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.CreditCardID)
                .IsRequired()
                .HasColumnName("CreditCardID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.CreditCard)
                .WithMany(t => t.PersonCreditCards)
                .HasForeignKey(d => d.CreditCardID)
                .HasConstraintName("FK_PersonCreditCard_CreditCard_CreditCardID")
                ;
            builder.HasOne(t => t.Person)
                .WithMany(t => t.PersonCreditCards)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_PersonCreditCard_Person_BusinessEntityID")
                ;

            #endregion // Generated Configure
        }
    }
}
