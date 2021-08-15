using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.VProductModelInstructions" />
    /// </summary>
    public partial class VProductModelInstructionsMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.VProductModelInstructions>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.VProductModelInstructions" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.VProductModelInstructions> builder)
        {
            #region Generated Configure

            // table
            builder.ToView("vProductModelInstructions", "Production");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.ProductModelID)
                .IsRequired()
                .HasColumnName("ProductModelID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.Instructions)
                .HasColumnName("Instructions")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.LocationID)
                .HasColumnName("LocationID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.SetupHours)
                .HasColumnName("SetupHours")
                .HasColumnType("decimal(9,4)")
                ;
            builder.Property(t => t.MachineHours)
                .HasColumnName("MachineHours")
                .HasColumnType("decimal(9,4)")
                ;
            builder.Property(t => t.LaborHours)
                .HasColumnName("LaborHours")
                .HasColumnType("decimal(9,4)")
                ;
            builder.Property(t => t.LotSize)
                .HasColumnName("LotSize")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Step)
                .HasColumnName("Step")
                .HasColumnType("nvarchar(1024)")
                .HasMaxLength(1024)
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
