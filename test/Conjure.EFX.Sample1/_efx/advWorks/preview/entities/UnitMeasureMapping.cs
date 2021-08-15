using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.UnitMeasure" />
    /// </summary>
    public partial class UnitMeasureMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.UnitMeasure>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.UnitMeasure" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.UnitMeasure> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("UnitMeasure", "Production");

            // key
            builder.HasKey(t => t.UnitMeasureCode);

            // properties
            builder.Property(t => t.UnitMeasureCode)
                .IsRequired()
                .HasColumnName("UnitMeasureCode")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3)
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
