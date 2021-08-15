using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.SpecialOffer" />
    /// </summary>
    public partial class SpecialOfferMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.SpecialOffer>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.SpecialOffer" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.SpecialOffer> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("SpecialOffer", "Sales");

            // key
            builder.HasKey(t => t.SpecialOfferID);

            // properties
            builder.Property(t => t.SpecialOfferID)
                .IsRequired()
                .HasColumnName("SpecialOfferID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.Description)
                .IsRequired()
                .HasColumnName("Description")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255)
                ;
            builder.Property(t => t.DiscountPct)
                .IsRequired()
                .HasColumnName("DiscountPct")
                .HasColumnType("smallmoney")
                .HasDefaultValueSql("((0.00))")
                ;
            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.Category)
                .IsRequired()
                .HasColumnName("Category")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.EndDate)
                .IsRequired()
                .HasColumnName("EndDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.MinQty)
                .IsRequired()
                .HasColumnName("MinQty")
                .HasColumnType("int")
                ;
            builder.Property(t => t.MaxQty)
                .HasColumnName("MaxQty")
                .HasColumnType("int")
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
