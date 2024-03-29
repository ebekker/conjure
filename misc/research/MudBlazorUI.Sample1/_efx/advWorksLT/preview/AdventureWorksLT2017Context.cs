#pragma warning disable IDE0073 // The file header is missing or not located at the top of the file
/** THIS IS AUTOGENERATED BY CONJURE EFX **/
#pragma warning restore IDE0073 // The file header is missing or not located at the top of the file

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConjureApp.Data
{
    /// <summary>
    /// A <see cref="DbContext" /> instance represents a session with the database and can be used to query and save instances of entities.
    /// </summary>
    public partial class AdventureWorksLT2017Context : Conjure.BlazorKit.Data.DbContextBase
    {
        private const string DesignTimeProvider = "SqlServer";
        private const string DesignTimeConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=AdventureWorksLT2017;Integrated Security=True";


        /// <summary>
        /// Initializes a new instance of the <see cref="AdventureWorksLT2017Context"/> class.
        /// </summary>
        /// <param name="options">The options to be used by this <see cref="DbContext" />.</param>
        public AdventureWorksLT2017Context(DbContextOptions<AdventureWorksLT2017Context> options)
            : base(options)
        {
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.Address"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.Address"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.Address> Addresses { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.BuildVersion"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.BuildVersion"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.BuildVersion> BuildVersions { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.CustomerAddress"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.CustomerAddress"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.CustomerAddress> CustomerAddresses { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.Customer"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.Customer"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.Customer> Customers { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.ErrorLog"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.ErrorLog"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.ErrorLog> ErrorLogs { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.ProductCategory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.ProductCategory"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.ProductCategory> ProductCategories { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.ProductDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.ProductDescription"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.ProductDescription> ProductDescriptions { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.ProductModelProductDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.ProductModelProductDescription"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.ProductModelProductDescription> ProductModelProductDescriptions { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.ProductModel"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.ProductModel"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.ProductModel> ProductModels { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.Product"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.Product"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.Product> Products { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.SalesOrderDetail"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.SalesOrderDetail"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.SalesOrderDetail> SalesOrderDetails { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.SalesOrderHeader"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.SalesOrderHeader"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.SalesOrderHeader> SalesOrderHeaders { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.VGetAllCategories"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.VGetAllCategories"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.VGetAllCategories> VGetAllCategories { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.VProductAndDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.VProductAndDescription"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.VProductAndDescription> VProductAndDescriptions { get; set; } = default!;

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.VProductModelCatalogDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="ConjureApp.Data.Entities.VProductModelCatalogDescription"/>.
        /// </value>
        public virtual DbSet<ConjureApp.Data.Entities.VProductModelCatalogDescription> VProductModelCatalogDescriptions { get; set; } = default!;

        #endregion // Generated Properties

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DesignTimeConnectionString);
            }
        }

        /// <summary>
        /// Configure the model that was discovered from the entity types exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on this context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.AddressMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.BuildVersionMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.CustomerAddressMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.CustomerMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.ErrorLogMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.ProductCategoryMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.ProductDescriptionMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.ProductMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.ProductModelMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.ProductModelProductDescriptionMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.SalesOrderDetailMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.SalesOrderHeaderMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.VGetAllCategoriesMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.VProductAndDescriptionMap());
            modelBuilder.ApplyConfiguration(new ConjureApp.Data.Mapping.VProductModelCatalogDescriptionMap());
            #endregion // Generated Configuration
        }
    }
}
