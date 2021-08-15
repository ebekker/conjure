using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.Location" />
    /// </summary>
    public partial class LocationMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.Location>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.Location" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.Location> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("Location", "Production");

            // key
            builder.HasKey(t => t.LocationID);

            // properties
            builder.Property(t => t.LocationID)
                .IsRequired()
                .HasColumnName("LocationID")
                .HasColumnType("smallint")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.CostRate)
                .IsRequired()
                .HasColumnName("CostRate")
                .HasColumnType("smallmoney")
                .HasDefaultValueSql("((0.00))")
                ;
            builder.Property(t => t.Availability)
                .IsRequired()
                .HasColumnName("Availability")
                .HasColumnType("decimal(8,2)")
                .HasDefaultValueSql("((0.00))")
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
