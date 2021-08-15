using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.ErrorLog" />
    /// </summary>
    public partial class ErrorLogMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.ErrorLog>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.ErrorLog" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.ErrorLog> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("ErrorLog", "dbo");

            // key
            builder.HasKey(t => t.ErrorLogID);

            // properties
            builder.Property(t => t.ErrorLogID)
                .IsRequired()
                .HasColumnName("ErrorLogID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.ErrorTime)
                .IsRequired()
                .HasColumnName("ErrorTime")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())")
                ;
            builder.Property(t => t.UserName)
                .IsRequired()
                .HasColumnName("UserName")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128)
                ;
            builder.Property(t => t.ErrorNumber)
                .IsRequired()
                .HasColumnName("ErrorNumber")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ErrorSeverity)
                .HasColumnName("ErrorSeverity")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ErrorState)
                .HasColumnName("ErrorState")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ErrorProcedure)
                .HasColumnName("ErrorProcedure")
                .HasColumnType("nvarchar(126)")
                .HasMaxLength(126)
                ;
            builder.Property(t => t.ErrorLine)
                .HasColumnName("ErrorLine")
                .HasColumnType("int")
                ;
            builder.Property(t => t.ErrorMessage)
                .IsRequired()
                .HasColumnName("ErrorMessage")
                .HasColumnType("nvarchar(4000)")
                .HasMaxLength(4000)
                ;

            // relationships

            #endregion // Generated Configure
        }
    }
}
