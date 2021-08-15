using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.VProductAndDescription" />
    /// </summary>
    public partial class VProductAndDescriptionMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.VProductAndDescription>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.VProductAndDescription" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.VProductAndDescription> builder)
        {
            #region Generated Configure

            // table
            builder.ToView("vProductAndDescription", "Production");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.ProductID)
                .IsRequired()
                .HasColumnName("ProductID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.ProductModel)
                .IsRequired()
                .HasColumnName("ProductModel")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.CultureID)
                .IsRequired()
                .HasColumnName("CultureID")
                .HasColumnType("nchar(6)")
                .HasMaxLength(6)
                ;
            builder.Property(t => t.Description)
                .IsRequired()
                .HasColumnName("Description")
                .HasColumnType("nvarchar(400)")
                .HasMaxLength(400)
                ;

            // relationships

            #endregion // Generated Configure
        }
    }
}
