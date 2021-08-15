using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.SalesReason" />
    /// </summary>
    public partial class SalesReasonMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.SalesReason>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.SalesReason" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.SalesReason> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("SalesReason", "Sales");

            // key
            builder.HasKey(t => t.SalesReasonID);

            // properties
            builder.Property(t => t.SalesReasonID)
                .IsRequired()
                .HasColumnName("SalesReasonID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.ReasonType)
                .IsRequired()
                .HasColumnName("ReasonType")
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
