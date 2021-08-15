using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ProductPhoto" />
    /// </summary>
    public partial class ProductPhotoMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ProductPhoto>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ProductPhoto" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ProductPhoto> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ProductPhoto", "Production");

            // key
            builder.HasKey(t => t.ProductPhotoID);

            // properties
            builder.Property(t => t.ProductPhotoID)
                .IsRequired()
                .HasColumnName("ProductPhotoID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.ThumbNailPhoto)
                .HasColumnName("ThumbNailPhoto")
                .HasColumnType("varbinary(max)")
                ;
            builder.Property(t => t.ThumbnailPhotoFileName)
                .HasColumnName("ThumbnailPhotoFileName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.LargePhoto)
                .HasColumnName("LargePhoto")
                .HasColumnType("varbinary(max)")
                ;
            builder.Property(t => t.LargePhotoFileName)
                .HasColumnName("LargePhotoFileName")
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
