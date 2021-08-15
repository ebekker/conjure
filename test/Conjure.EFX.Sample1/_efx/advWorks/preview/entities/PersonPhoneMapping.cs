using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.PersonPhone" />
    /// </summary>
    public partial class PersonPhoneMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.PersonPhone>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.PersonPhone" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.PersonPhone> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("PersonPhone", "Person");

            // key
            builder.HasKey(t => new {
                t.BusinessEntityID,
                t.PhoneNumber,
                t.PhoneNumberTypeID
            });
            

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.PhoneNumber)
                .IsRequired()
                .HasColumnName("PhoneNumber")
                .HasColumnType("nvarchar(25)")
                .HasMaxLength(25)
                ;
            builder.Property(t => t.PhoneNumberTypeID)
                .IsRequired()
                .HasColumnName("PhoneNumberTypeID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.Person)
                .WithMany(t => t.PersonPhones)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_PersonPhone_Person_BusinessEntityID")
                ;
            builder.HasOne(t => t.PhoneNumberType)
                .WithMany(t => t.PersonPhones)
                .HasForeignKey(d => d.PhoneNumberTypeID)
                .HasConstraintName("FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID")
                ;

            #endregion // Generated Configure
        }
    }
}
