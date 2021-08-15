using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.Culture" />
    /// </summary>
    public partial class CultureMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.Culture>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.Culture" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.Culture> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("Culture", "Production");

            // key
            builder.HasKey(t => t.CultureID);

            // properties
            builder.Property(t => t.CultureID)
                .IsRequired()
                .HasColumnName("CultureID")
                .HasColumnType("nchar(6)")
                .HasMaxLength(6)
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
