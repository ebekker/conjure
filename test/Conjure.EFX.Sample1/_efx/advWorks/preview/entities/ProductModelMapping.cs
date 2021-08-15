using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ProductModel" />
    /// </summary>
    public partial class ProductModelMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ProductModel>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ProductModel" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ProductModel> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ProductModel", "Production");

            // key
            builder.HasKey(t => t.ProductModelID);

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
            builder.Property(t => t.CatalogDescription)
                .HasColumnName("CatalogDescription")
                .HasColumnType("xml")
                ;
            builder.Property(t => t.Instructions)
                .HasColumnName("Instructions")
                .HasColumnType("xml")
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
