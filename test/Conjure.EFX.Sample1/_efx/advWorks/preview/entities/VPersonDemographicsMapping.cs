using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.VPersonDemographics" />
    /// </summary>
    public partial class VPersonDemographicsMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.VPersonDemographics>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.VPersonDemographics" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.VPersonDemographics> builder)
        {
            #region Generated Configure

            // table
            builder.ToView("vPersonDemographics", "Sales");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.TotalPurchaseYTD)
                .HasColumnName("TotalPurchaseYTD")
                .HasColumnType("money")
                ;
            builder.Property(t => t.DateFirstPurchase)
                .HasColumnName("DateFirstPurchase")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.BirthDate)
                .HasColumnName("BirthDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.MaritalStatus)
                .HasColumnName("MaritalStatus")
                .HasColumnType("nvarchar(1)")
                .HasMaxLength(1)
                ;
            builder.Property(t => t.YearlyIncome)
                .HasColumnName("YearlyIncome")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30)
                ;
            builder.Property(t => t.Gender)
                .HasColumnName("Gender")
                .HasColumnType("nvarchar(1)")
                .HasMaxLength(1)
                ;
            builder.Property(t => t.TotalChildren)
                .HasColumnName("TotalChildren")
                .HasColumnType("int")
                ;
            builder.Property(t => t.NumberChildrenAtHome)
                .HasColumnName("NumberChildrenAtHome")
                .HasColumnType("int")
                ;
            builder.Property(t => t.Education)
                .HasColumnName("Education")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30)
                ;
            builder.Property(t => t.Occupation)
                .HasColumnName("Occupation")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30)
                ;
            builder.Property(t => t.HomeOwnerFlag)
                .HasColumnName("HomeOwnerFlag")
                .HasColumnType("bit")
                ;
            builder.Property(t => t.NumberCarsOwned)
                .HasColumnName("NumberCarsOwned")
                .HasColumnType("int")
                ;

            // relationships

            #endregion // Generated Configure
        }
    }
}
