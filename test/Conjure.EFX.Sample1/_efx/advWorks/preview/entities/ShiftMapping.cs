using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.Shift" />
    /// </summary>
    public partial class ShiftMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.Shift>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.Shift" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.Shift> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("Shift", "HumanResources");

            // key
            builder.HasKey(t => t.ShiftID);

            // properties
            builder.Property(t => t.ShiftID)
                .IsRequired()
                .HasColumnName("ShiftID")
                .HasColumnType("tinyint")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.StartTime)
                .IsRequired()
                .HasColumnName("StartTime")
                .HasColumnType("time")
                ;
            builder.Property(t => t.EndTime)
                .IsRequired()
                .HasColumnName("EndTime")
                .HasColumnType("time")
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
