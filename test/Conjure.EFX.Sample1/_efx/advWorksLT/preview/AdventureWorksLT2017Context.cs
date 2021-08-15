using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AdvWorksLT.Data
{
    /// <summary>
    /// A <see cref="DbContext" /> instance represents a session with the database and can be used to query and save instances of entities.
    /// </summary>
    public partial class AdventureWorksLT2017Context : DbContext
    {        /// <summary>
        /// Initializes a new instance of the <see cref="AdventureWorksLT2017Context"/> class.
        /// </summary>
        /// <param name="options">The options to be used by this <see cref="DbContext" />.</param>
        public AdventureWorksLT2017Context(DbContextOptions<AdventureWorksLT2017Context> options)
            : base(options)
        {
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.Address"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.Address"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.BuildVersion"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.BuildVersion"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.BuildVersion> BuildVersions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.CustomerAddress"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.CustomerAddress"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.CustomerAddress> CustomerAddresses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.Customer"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.Customer"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.ErrorLog"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.ErrorLog"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.ErrorLog> ErrorLogs { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.ProductCategory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.ProductCategory"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.ProductCategory> ProductCategories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.ProductDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.ProductDescription"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.ProductDescription> ProductDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.ProductModelProductDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.ProductModelProductDescription"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.ProductModelProductDescription> ProductModelProductDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.ProductModel"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.ProductModel"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.ProductModel> ProductModels { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.Product"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.Product"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.SalesOrderDetail"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.SalesOrderDetail"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.SalesOrderDetail> SalesOrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.SalesOrderHeader"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.SalesOrderHeader"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.SalesOrderHeader> SalesOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.VGetAllCategories"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.VGetAllCategories"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.VGetAllCategories> VGetAllCategories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.VProductAndDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.VProductAndDescription"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.VProductAndDescription> VProductAndDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.VProductModelCatalogDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorksLT.Data.Entities.VProductModelCatalogDescription"/>.
        /// </value>
        public virtual DbSet<AdvWorksLT.Data.Entities.VProductModelCatalogDescription> VProductModelCatalogDescriptions { get; set; }

        #endregion // Generated Properties

        /// <summary>
        /// Configure the model that was discovered from the entity types exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on this context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.AddressMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.BuildVersionMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.CustomerAddressMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.CustomerMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.ErrorLogMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.ProductCategoryMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.ProductDescriptionMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.ProductMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.ProductModelMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.ProductModelProductDescriptionMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.SalesOrderDetailMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.SalesOrderHeaderMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.VGetAllCategoriesMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.VProductAndDescriptionMap());
            modelBuilder.ApplyConfiguration(new AdvWorksLT.Data.Mapping.VProductModelCatalogDescriptionMap());
            #endregion // Generated Configuration
        }
    }
}
