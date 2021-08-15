using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ShipMethod" />
    /// </summary>
    public partial class ShipMethodMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ShipMethod>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ShipMethod" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ShipMethod> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ShipMethod", "Purchasing");

            // key
            builder.HasKey(t => t.ShipMethodID);

            // properties
            builder.Property(t => t.ShipMethodID)
                .IsRequired()
                .HasColumnName("ShipMethodID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.ShipBase)
                .IsRequired()
                .HasColumnName("ShipBase")
                .HasColumnType("money")
                .HasDefaultValueSql("((0.00))")
                ;
            builder.Property(t => t.ShipRate)
                .IsRequired()
                .HasColumnName("ShipRate")
                .HasColumnType("money")
                .HasDefaultValueSql("((0.00))")
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
