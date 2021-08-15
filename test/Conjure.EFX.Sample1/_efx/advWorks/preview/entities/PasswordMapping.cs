using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.Password" />
    /// </summary>
    public partial class PasswordMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.Password>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.Password" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.Password> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("Password", "Person");

            // key
            builder.HasKey(t => t.BusinessEntityID);

            // properties
            builder.Property(t => t.BusinessEntityID)
                .IsRequired()
                .HasColumnName("BusinessEntityID")
                .HasColumnType("int")
                ;
            builder.Property(t => t.PasswordHash)
                .IsRequired()
                .HasColumnName("PasswordHash")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128)
                ;
            builder.Property(t => t.PasswordSalt)
                .IsRequired()
                .HasColumnName("PasswordSalt")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
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
            builder.HasOne(t => t.Person)
                .WithOne(t => t.Password)
                .HasForeignKey<AdvWorks.Data.Entities.Password>(d => d.BusinessEntityID)
                .HasConstraintName("FK_Password_Person_BusinessEntityID")
                ;

            #endregion // Generated Configure
        }
    }
}
