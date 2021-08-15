using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.EmailAddress" />
    /// </summary>
    public partial class EmailAddressMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.EmailAddress>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.EmailAddress" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.EmailAddress> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("EmailAddress", "Person");

            // key
            builder.HasKey(t => new {
                t.BusinessEntityID,
                t.EmailAddressID
            });
            

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.EmailAddressID)
                .IsRequired()
                .HasColumnName("EmailAddressID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.EmailAddressMember)
                .HasColumnName("EmailAddress")
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
            builder.HasOne(t => t.Person)
                .WithMany(t => t.EmailAddresses)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_EmailAddress_Person_BusinessEntityID")
                ;

            #endregion // Generated Configure
        }
    }
}
