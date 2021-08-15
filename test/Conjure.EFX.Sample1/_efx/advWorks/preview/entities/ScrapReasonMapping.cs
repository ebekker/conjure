using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ScrapReason" />
    /// </summary>
    public partial class ScrapReasonMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ScrapReason>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ScrapReason" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ScrapReason> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ScrapReason", "Production");

            // key
            builder.HasKey(t => t.ScrapReasonID);

            // properties
            builder.Property(t => t.ScrapReasonID)
                .IsRequired()
                .HasColumnName("ScrapReasonID")
                .HasColumnType("smallint")
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
