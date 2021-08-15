using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.EmployeePayHistory" />
    /// </summary>
    public partial class EmployeePayHistoryMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.EmployeePayHistory>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.EmployeePayHistory" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.EmployeePayHistory> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("EmployeePayHistory", "HumanResources");

            // key
            builder.HasKey(t => new {
                t.BusinessEntityID,
                t.RateChangeDate
            });
            

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.RateChangeDate)
                .IsRequired()
                .HasColumnName("RateChangeDate")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.Rate)
                .IsRequired()
                .HasColumnName("Rate")
                .HasColumnType("money")
                ;
            builder.Property(t => t.PayFrequency)
                .IsRequired()
                .HasColumnName("PayFrequency")
                .HasColumnType("tinyint")
                ;
            builder.Property(t => t.ModifiedDate)
                .IsRequired()
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;

            // relationships
            builder.HasOne(t => t.Employee)
                .WithMany(t => t.EmployeePayHistories)
                .HasForeignKey(d => d.BusinessEntityID)
                .HasConstraintName("FK_EmployeePayHistory_Employee_BusinessEntityID")
                ;

            #endregion // Generated Configure
        }
    }
}
