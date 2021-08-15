using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.Illustration" />
    /// </summary>
    public partial class IllustrationMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.Illustration>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.Illustration" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.Illustration> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("Illustration", "Production");

            // key
            builder.HasKey(t => t.IllustrationID);

            // properties
            builder.Property(t => t.IllustrationID)
                .IsRequired()
                .HasColumnName("IllustrationID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.Diagram)
                .HasColumnName("Diagram")
                .HasColumnType("xml")
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
