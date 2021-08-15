using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.Store" />
    /// </summary>
    public partial class StoreMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.Store>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.Store" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.Store> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("Store", "Sales");

            // key
            builder.HasKey(t => t.BusinessEntityID);

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.SalesPersonID)
                .HasColumnName("SalesPersonID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Demographics)
                .HasColumnName("Demographics")
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
            builder.HasOne(t => t.BusinessEntity)
                .WithOne(t => t.Store)
                .HasForeignKey<AdvWorks.Data.Entities.Store>(d => d.BusinessEntityID)
                .HasConstraintName("FK_Store_BusinessEntity_BusinessEntityID")
                ;
            builder.HasOne(t => t.SalesPerson)
                .WithMany(t => t.Stores)
                .HasForeignKey(d => d.SalesPersonID)
                .HasConstraintName("FK_Store_SalesPerson_SalesPersonID")
                ;

            #endregion // Generated Configure
        }
    }
}
