using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.AddressType" />
    /// </summary>
    public partial class AddressTypeMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.AddressType>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.AddressType" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.AddressType> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("AddressType", "Person");

            // key
            builder.HasKey(t => t.AddressTypeID);

            // properties
            builder.Property(t => t.AddressTypeID)
                .IsRequired()
                .HasColumnName("AddressTypeID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
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

            #endregion // Generated Configure
        }
    }
}
