using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AdvWorks.Data
{
    /// <summary>
    /// A <see cref="DbContext" /> instance represents a session with the database and can be used to query and save instances of entities.
    /// </summary>
    public partial class AdventureWorks2017Context : DbContext
    {        /// <summary>
        /// Initializes a new instance of the <see cref="AdventureWorks2017Context"/> class.
        /// </summary>
        /// <param name="options">The options to be used by this <see cref="DbContext" />.</param>
        public AdventureWorks2017Context(DbContextOptions<AdventureWorks2017Context> options)
            : base(options)
        {
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Address"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Address"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.AddressType"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.AddressType"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.AddressType> AddressTypes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.AWBuildVersion"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.AWBuildVersion"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.AWBuildVersion> AWBuildVersions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.BillOfMaterials"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.BillOfMaterials"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.BillOfMaterials> BillOfMaterials { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.BusinessEntity"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.BusinessEntity"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.BusinessEntity> BusinessEntities { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.BusinessEntityAddress"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.BusinessEntityAddress"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.BusinessEntityAddress> BusinessEntityAddresses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.BusinessEntityContact"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.BusinessEntityContact"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.BusinessEntityContact> BusinessEntityContacts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ContactType"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ContactType"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ContactType> ContactTypes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.CountryRegionCurrency"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.CountryRegionCurrency"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.CountryRegionCurrency> CountryRegionCurrencies { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.CountryRegion"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.CountryRegion"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.CountryRegion> CountryRegions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.CreditCard"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.CreditCard"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.CreditCard> CreditCards { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Culture"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Culture"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Culture> Cultures { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Currency"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Currency"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Currency> Currencies { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.CurrencyRate"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.CurrencyRate"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.CurrencyRate> CurrencyRates { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Customer"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Customer"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.DatabaseLog"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.DatabaseLog"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.DatabaseLog> DatabaseLogs { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Department"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Department"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Department> Departments { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.EmailAddress"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.EmailAddress"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.EmailAddress> EmailAddresses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.EmployeeDepartmentHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.EmployeeDepartmentHistory"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.EmployeePayHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.EmployeePayHistory"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.EmployeePayHistory> EmployeePayHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Employee"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Employee"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Employee> Employees { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ErrorLog"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ErrorLog"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ErrorLog> ErrorLogs { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Illustration"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Illustration"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Illustration> Illustrations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.JobCandidate"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.JobCandidate"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.JobCandidate> JobCandidates { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Location"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Location"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Location> Locations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Password"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Password"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Password> Passwords { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Person"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Person"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Person> People { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.PersonCreditCard"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.PersonCreditCard"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.PersonCreditCard> PersonCreditCards { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.PersonPhone"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.PersonPhone"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.PersonPhone> PersonPhones { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.PhoneNumberType"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.PhoneNumberType"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.PhoneNumberType> PhoneNumberTypes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductCategory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductCategory"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ProductCategory> ProductCategories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductCostHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductCostHistory"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ProductCostHistory> ProductCostHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductDescription"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ProductDescription> ProductDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductInventory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductInventory"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ProductInventory> ProductInventories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductListPriceHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductListPriceHistory"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ProductListPriceHistory> ProductListPriceHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductModelIllustration"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductModelIllustration"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ProductModelIllustration> ProductModelIllustrations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductModelProductDescriptionCulture"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductModelProductDescriptionCulture"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductModel"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductModel"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ProductModel> ProductModels { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductPhoto"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductPhoto"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ProductPhoto> ProductPhotos { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductProductPhoto"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductProductPhoto"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ProductProductPhoto> ProductProductPhotos { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductReview"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductReview"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ProductReview> ProductReviews { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Product"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Product"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductSubcategory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductSubcategory"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ProductSubcategory> ProductSubcategories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductVendor"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ProductVendor"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ProductVendor> ProductVendors { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.PurchaseOrderDetail"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.PurchaseOrderDetail"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.PurchaseOrderHeader"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.PurchaseOrderHeader"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesOrderDetail"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesOrderDetail"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.SalesOrderDetail> SalesOrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesOrderHeader"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesOrderHeader"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.SalesOrderHeader> SalesOrderHeaders { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesOrderHeaderSalesReason"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesOrderHeaderSalesReason"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesPerson"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesPerson"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.SalesPerson> SalesPeople { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesPersonQuotaHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesPersonQuotaHistory"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesReason"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesReason"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.SalesReason> SalesReasons { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesTaxRate"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesTaxRate"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.SalesTaxRate> SalesTaxRates { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesTerritory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesTerritory"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.SalesTerritory> SalesTerritories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesTerritoryHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SalesTerritoryHistory"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.SalesTerritoryHistory> SalesTerritoryHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ScrapReason"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ScrapReason"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ScrapReason> ScrapReasons { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Shift"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Shift"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Shift> Shifts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ShipMethod"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ShipMethod"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ShipMethod> ShipMethods { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ShoppingCartItem"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.ShoppingCartItem"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.ShoppingCartItem> ShoppingCartItems { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SpecialOfferProduct"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SpecialOfferProduct"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.SpecialOfferProduct> SpecialOfferProducts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SpecialOffer"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.SpecialOffer"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.SpecialOffer> SpecialOffers { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.StateProvince"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.StateProvince"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.StateProvince> StateProvinces { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Store"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Store"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Store> Stores { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.TransactionHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.TransactionHistory"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.TransactionHistory> TransactionHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.TransactionHistoryArchive"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.TransactionHistoryArchive"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.TransactionHistoryArchive> TransactionHistoryArchives { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.UnitMeasure"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.UnitMeasure"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.UnitMeasure> UnitMeasures { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VAdditionalContactInfo"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VAdditionalContactInfo"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VAdditionalContactInfo> VAdditionalContactInfos { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VEmployeeDepartmentHistory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VEmployeeDepartmentHistory"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VEmployeeDepartmentHistory> VEmployeeDepartmentHistories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VEmployeeDepartment"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VEmployeeDepartment"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VEmployeeDepartment> VEmployeeDepartments { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VEmployee"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VEmployee"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VEmployee> VEmployees { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Vendor"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.Vendor"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.Vendor> Vendors { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VIndividualCustomer"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VIndividualCustomer"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VIndividualCustomer> VIndividualCustomers { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VJobCandidateEducation"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VJobCandidateEducation"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VJobCandidateEducation> VJobCandidateEducations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VJobCandidateEmployment"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VJobCandidateEmployment"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VJobCandidateEmployment> VJobCandidateEmployments { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VJobCandidate"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VJobCandidate"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VJobCandidate> VJobCandidates { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VPersonDemographics"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VPersonDemographics"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VPersonDemographics> VPersonDemographics { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VProductAndDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VProductAndDescription"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VProductAndDescription> VProductAndDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VProductModelCatalogDescription"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VProductModelCatalogDescription"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VProductModelCatalogDescription> VProductModelCatalogDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VProductModelInstructions"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VProductModelInstructions"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VProductModelInstructions> VProductModelInstructions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VSalesPerson"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VSalesPerson"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VSalesPerson> VSalesPeople { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VSalesPersonSalesByFiscalYears"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VSalesPersonSalesByFiscalYears"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VSalesPersonSalesByFiscalYears> VSalesPersonSalesByFiscalYears { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VStateProvinceCountryRegion"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VStateProvinceCountryRegion"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VStateProvinceCountryRegion> VStateProvinceCountryRegions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VStoreWithAddresses"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VStoreWithAddresses"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VStoreWithAddresses> VStoreWithAddresses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VStoreWithContacts"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VStoreWithContacts"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VStoreWithContacts> VStoreWithContacts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VStoreWithDemographics"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VStoreWithDemographics"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VStoreWithDemographics> VStoreWithDemographics { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VVendorWithAddresses"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VVendorWithAddresses"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VVendorWithAddresses> VVendorWithAddresses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VVendorWithContacts"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.VVendorWithContacts"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.VVendorWithContacts> VVendorWithContacts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.WorkOrderRouting"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.WorkOrderRouting"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.WorkOrderRouting> WorkOrderRoutings { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.WorkOrder"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="AdvWorks.Data.Entities.WorkOrder"/>.
        /// </value>
        public virtual DbSet<AdvWorks.Data.Entities.WorkOrder> WorkOrders { get; set; }

        #endregion // Generated Properties

        /// <summary>
        /// Configure the model that was discovered from the entity types exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on this context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.AddressMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.AddressTypeMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.AWBuildVersionMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.BillOfMaterialsMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.BusinessEntityAddressMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.BusinessEntityContactMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.BusinessEntityMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ContactTypeMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.CountryRegionCurrencyMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.CountryRegionMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.CreditCardMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.CultureMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.CurrencyMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.CurrencyRateMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.CustomerMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.DatabaseLogMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.DepartmentMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.EmailAddressMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.EmployeeDepartmentHistoryMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.EmployeeMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.EmployeePayHistoryMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ErrorLogMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.IllustrationMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.JobCandidateMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.LocationMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.PasswordMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.PersonCreditCardMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.PersonMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.PersonPhoneMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.PhoneNumberTypeMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductCategoryMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductCostHistoryMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductDescriptionMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductInventoryMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductListPriceHistoryMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductModelIllustrationMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductModelMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductModelProductDescriptionCultureMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductPhotoMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductProductPhotoMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductReviewMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductSubcategoryMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ProductVendorMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.PurchaseOrderDetailMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.PurchaseOrderHeaderMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.SalesOrderDetailMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.SalesOrderHeaderMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.SalesOrderHeaderSalesReasonMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.SalesPersonMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.SalesPersonQuotaHistoryMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.SalesReasonMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.SalesTaxRateMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.SalesTerritoryHistoryMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.SalesTerritoryMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ScrapReasonMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ShiftMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ShipMethodMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.ShoppingCartItemMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.SpecialOfferMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.SpecialOfferProductMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.StateProvinceMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.StoreMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.TransactionHistoryArchiveMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.TransactionHistoryMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.UnitMeasureMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VAdditionalContactInfoMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VEmployeeDepartmentHistoryMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VEmployeeDepartmentMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VEmployeeMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VendorMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VIndividualCustomerMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VJobCandidateEducationMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VJobCandidateEmploymentMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VJobCandidateMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VPersonDemographicsMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VProductAndDescriptionMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VProductModelCatalogDescriptionMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VProductModelInstructionsMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VSalesPersonMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VSalesPersonSalesByFiscalYearsMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VStateProvinceCountryRegionMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VStoreWithAddressesMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VStoreWithContactsMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VStoreWithDemographicsMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VVendorWithAddressesMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.VVendorWithContactsMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.WorkOrderMap());
            modelBuilder.ApplyConfiguration(new AdvWorks.Data.Mapping.WorkOrderRoutingMap());
            #endregion // Generated Configuration
        }
    }
}
