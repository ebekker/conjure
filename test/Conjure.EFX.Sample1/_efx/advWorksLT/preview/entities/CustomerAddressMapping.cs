using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorksLT.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorksLT.Data.Entities.CustomerAddress" />
    /// </summary>
    public partial class CustomerAddressMap
        : IEntityTypeConfiguration<AdvWorksLT.Data.Entities.CustomerAddress>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorksLT.Data.Entities.CustomerAddress" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorksLT.Data.Entities.CustomerAddress> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("CustomerAddress", "SalesLT");

            // key
            builder.HasKey(t => new {
                t.CustomerID,
                t.AddressID
            });
            

            // properties
            builder.Property(t => t.CustomerID)
                .IsRequired()
                .HasColumnName("CustomerID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.AddressID)
                .IsRequired()
                .HasColumnName("AddressID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.AddressType)
                .IsRequired()
                .HasColumnName("AddressType")
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
            builder.HasOne(t => t.Address)
                .WithMany(t => t.CustomerAddresses)
                .HasForeignKey(d => d.AddressID)
                .HasConstraintName("FK_CustomerAddress_Address_AddressID")
                ;
            builder.HasOne(t => t.Customer)
                .WithMany(t => t.CustomerAddresses)
                .HasForeignKey(d => d.CustomerID)
                .HasConstraintName("FK_CustomerAddress_Customer_CustomerID")
                ;

            #endregion // Generated Configure
        }
    }
}
