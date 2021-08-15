using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ContactType" />
    /// </summary>
    public partial class ContactTypeMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ContactType>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ContactType" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ContactType> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ContactType", "Person");

            // key
            builder.HasKey(t => t.ContactTypeID);

            // properties
            builder.Property(t => t.ContactTypeID)
                .IsRequired()
                .HasColumnName("ContactTypeID")
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
