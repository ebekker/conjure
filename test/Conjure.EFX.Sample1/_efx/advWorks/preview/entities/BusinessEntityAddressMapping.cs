using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.BusinessEntityAddress" />
    /// </summary>
    public partial class BusinessEntityAddressMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.BusinessEntityAddress>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.BusinessEntityAddress" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.BusinessEntityAddress> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("BusinessEntityAddress", "Person");

            // key
            builder.HasKey(t => new {
                t.BusinessEntityID,
                t.AddressID,
                t.AddressTypeID
            });
            

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.AddressID)
                .IsRequired()
                .HasColumnName("AddressID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.AddressTypeID)
                .IsRequired()
                .HasColumnName("AddressTypeID")
                .HasColumnType("int")
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
            builder.HasOne(t => t.Address)
                .WithMany(t => t.BusinessEntityAddresses)
                .HasForeignKey(d => d.AddressID)
                .HasConstraintName("FK_BusinessEntityAddress_Address_AddressID")
                ;
            builder.HasOne(t => t.AddressType)
                .WithMany(t => t.BusinessEntityAddresses)
                .HasForeignKey(d => d.AddressTypeID)
                .HasConstraintName("FK_BusinessEntityAddress_AddressType_AddressTypeID")
                ;
            builder.HasOne(t => t.BusinessEntity)
                .WithMany(t => t.BusinessEntityAddresses)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID")
                ;

            #endregion // Generated Configure
        }
    }
}
