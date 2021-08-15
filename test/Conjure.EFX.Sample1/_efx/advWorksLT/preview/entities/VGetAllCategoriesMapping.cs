using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorksLT.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorksLT.Data.Entities.VGetAllCategories" />
    /// </summary>
    public partial class VGetAllCategoriesMap
        : IEntityTypeConfiguration<AdvWorksLT.Data.Entities.VGetAllCategories>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorksLT.Data.Entities.VGetAllCategories" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorksLT.Data.Entities.VGetAllCategories> builder)
        {
            #region Generated Configure

            // table
            builder.ToView("vGetAllCategories", "SalesLT");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.ParentProductCategoryName)
                .IsRequired()
                .HasColumnName("ParentProductCategoryName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.ProductCategoryName)
                .HasColumnName("ProductCategoryName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.ProductCategoryID)
                .HasColumnName("ProductCategoryID")
                .HasColumnType("int")
                ;

            // relationships

            #endregion // Generated Configure
        }
    }
}
