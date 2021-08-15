using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdvWorks.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="AdvWorks.Data.Entities.DatabaseLog" />
    /// </summary>
    public partial class DatabaseLogMap
        : IEntityTypeConfiguration<AdvWorks.Data.Entities.DatabaseLog>
    {
        /// <summary>
        /// Configures the entity of type <see cref="AdvWorks.Data.Entities.DatabaseLog" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdvWorks.Data.Entities.DatabaseLog> builder)
        {
            #region Generated Configure

            // table
            builder.ToTable("DatabaseLog", "dbo");

            // key
            builder.HasKey(t => t.DatabaseLogID);

            // properties
            builder.Property(t => t.DatabaseLogID)
                .IsRequired()
                .HasColumnName("DatabaseLogID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                ;
            builder.Property(t => t.PostTime)
                .IsRequired()
                .HasColumnName("PostTime")
                .HasColumnType("datetime")
                ;
            builder.Property(t => t.DatabaseUser)
                .IsRequired()
                .HasColumnName("DatabaseUser")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128)
                ;
            builder.Property(t => t.Event)
                .IsRequired()
                .HasColumnName("Event")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128)
                ;
            builder.Property(t => t.Schema)
                .HasColumnName("Schema")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128)
                ;
            builder.Property(t => t.Object)
                .HasColumnName("Object")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128)
                ;
            builder.Property(t => t.Tsql)
                .IsRequired()
                .HasColumnName("TSQL")
                .HasColumnType("nvarchar(max)")
                ;
            builder.Property(t => t.XmlEvent)
                .IsRequired()
                .HasColumnName("XmlEvent")
                .HasColumnType("xml")
                ;

            // relationships

            #endregion // Generated Configure
        }
    }
}
