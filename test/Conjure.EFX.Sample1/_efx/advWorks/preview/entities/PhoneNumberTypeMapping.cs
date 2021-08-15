using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.PhoneNumberType" />
    /// </summary>
    public partial class PhoneNumberTypeMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.PhoneNumberType>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.PhoneNumberType" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.PhoneNumberType> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("PhoneNumberType", "Person");

            // key
            builder.HasKey(t => t.PhoneNumberTypeID);

            // properties
            builder.Property(t => t.PhoneNumberTypeID)
                .IsRequired()
                .HasColumnName("PhoneNumberTypeID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
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
