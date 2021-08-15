using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.Vendor" />
    /// </summary>
    public partial class VendorMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.Vendor>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.Vendor" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.Vendor> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("Vendor", "Purchasing");

            // key
            builder.HasKey(t => t.BusinessEntityID);

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.AccountNumber)
                .IsRequired()
                .HasColumnName("AccountNumber")
                .HasColumnType("nvarchar(15)")
                .HasMaxLength(15)
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.CreditRating)
                .IsRequired()
                .HasColumnName("CreditRating")
                .HasColumnType("tinyint")
                ;
            builder.Property(t => t.PreferredVendorStatus)
                .IsRequired()
                .HasColumnName("PreferredVendorStatus")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))")
                ;
            builder.Property(t => t.ActiveFlag)
                .IsRequired()
                .HasColumnName("ActiveFlag")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))")
                ;
            builder.Property(t => t.PurchasingWebServiceURL)
                .HasColumnName("PurchasingWebServiceURL")
                .HasColumnType("nvarchar(1024)")
                .HasMaxLength(1024)
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.BusinessEntity)
                .WithOne(t => t.Vendor)
                .HasForeignKey<AdvWorks.Data.Entities.Vendor>(d => d.BusinessEntityID)
                .HasConstraintName("FK_Vendor_BusinessEntity_BusinessEntityID")
                ;

            #endregion // Generated Configure
        }
    }
}
