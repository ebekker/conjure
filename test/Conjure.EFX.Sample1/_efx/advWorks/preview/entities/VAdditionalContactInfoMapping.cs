using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.VAdditionalContactInfo" />
    /// </summary>
    public partial class VAdditionalContactInfoMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.VAdditionalContactInfo>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.VAdditionalContactInfo" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.VAdditionalContactInfo> builder)
        {
            #region Generated Configure

            // table
            builder.ToView("vAdditionalContactInfo", "Person");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.MiddleName)
                .HasColumnName("MiddleName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.TelephoneNumber)
                .HasColumnName("TelephoneNumber")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.TelephoneSpecialInstructions)
                .HasColumnName("TelephoneSpecialInstructions")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.Street)
                .HasColumnName("Street")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.City)
                .HasColumnName("City")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.StateProvince)
                .HasColumnName("StateProvince")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.PostalCode)
                .HasColumnName("PostalCode")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.CountryRegion)
                .HasColumnName("CountryRegion")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.HomeAddressSpecialInstructions)
                .HasColumnName("HomeAddressSpecialInstructions")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.EMailAddress)
                .HasColumnName("EMailAddress")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128)
                ;
            builder.Property(t => t.EMailSpecialInstructions)
                .HasColumnName("EMailSpecialInstructions")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.EMailTelephoneNumber)
                .HasColumnName("EMailTelephoneNumber")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.Rowguid)
                .IsRequired()
                .HasColumnName("rowguid")
                .HasColumnType("uniqueidentifier")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                ;

            // relationships

            #endregion // Generated Configure
        }
    }
}
