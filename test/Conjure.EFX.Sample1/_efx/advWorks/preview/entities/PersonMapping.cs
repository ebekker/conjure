using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.Person" />
    /// </summary>
    public partial class PersonMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.Person>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.Person" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.Person> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("Person", "Person");

            // key
            builder.HasKey(t => t.BusinessEntityID);

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.PersonType)
                .IsRequired()
                .HasColumnName("PersonType")
                .HasColumnType("nchar(2)")
                .HasMaxLength(2)
                ;
            builder.Property(t => t.NameStyle)
                .IsRequired()
                .HasColumnName("NameStyle")
                .HasColumnType("bit")
                ;
            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasColumnType("nvarchar(8)")
                .HasMaxLength(8)
                ;
            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.MiddleName)
                .HasColumnName("MiddleName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                ;
            builder.Property(t => t.Suffix)
                .HasColumnName("Suffix")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10)
                ;
            builder.Property(t => t.EmailPromotion)
                .IsRequired()
                .HasColumnName("EmailPromotion")
                .HasColumnType("int")
                ;
            builder.Property(t => t.AdditionalContactInfo)
                .HasColumnName("AdditionalContactInfo")
                .HasColumnType("xml")
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
                .WithOne(t => t.Person)
                .HasForeignKey<AdvWorks.Data.Entities.Person>(d => d.BusinessEntityID)
                .HasConstraintName("FK_Person_BusinessEntity_BusinessEntityID")
                ;

            #endregion // Generated Configure
        }
    }
}
