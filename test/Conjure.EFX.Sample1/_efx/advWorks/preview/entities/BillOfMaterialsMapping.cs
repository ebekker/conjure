using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.BillOfMaterials" />
    /// </summary>
    public partial class BillOfMaterialsMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.BillOfMaterials>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.BillOfMaterials" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.BillOfMaterials> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("BillOfMaterials", "Production");

            // key
            builder.HasKey(t => t.BillOfMaterialsID);

            // properties
            builder.Property(t => t.BillOfMaterialsID)
                .IsRequired()
                .HasColumnName("BillOfMaterialsID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.ProductAssemblyID)
                .HasColumnName("ProductAssemblyID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ComponentID)
                .IsRequired()
                .HasColumnName("ComponentID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.StartDate)
                .IsRequired()
                .HasColumnName("StartDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;
            builder.Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.UnitMeasureCode)
                .IsRequired()
                .HasColumnName("UnitMeasureCode")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3)
                ;
            builder.Property(t => t.BOMLevel)
                .IsRequired()
                .HasColumnName("BOMLevel")
                .HasColumnType("smallint")
                ;
            builder.Property(t => t.PerAssemblyQty)
                .IsRequired()
                .HasColumnName("PerAssemblyQty")
                .HasColumnType("decimal(8,2)")
                .HasDefaultValueSql("((1.00))")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.ComponentProduct)
                .WithMany(t => t.ComponentBillOfMaterials)
                .HasForeignKey(d => d.ComponentID)
                .HasConstraintName("FK_BillOfMaterials_Product_ComponentID")
                ;
            builder.HasOne(t => t.AssemblyProduct)
                .WithMany(t => t.AssemblyBillOfMaterials)
                .HasForeignKey(d => d.ProductAssemblyID)
                .HasConstraintName("FK_BillOfMaterials_Product_ProductAssemblyID")
                ;
            builder.HasOne(t => t.UnitMeasure)
                .WithMany(t => t.BillOfMaterials)
                .HasForeignKey(d => d.UnitMeasureCode)
                .HasConstraintName("FK_BillOfMaterials_UnitMeasure_UnitMeasureCode")
                ;

            #endregion // Generated Configure
        }
    }
}
