using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Product'
    /// </summary>
    public partial class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product()
        {
            #region Generated Constructor

            AssemblyBillOfMaterials = new HashSet<BillOfMaterials>();
            ComponentBillOfMaterials = new HashSet<BillOfMaterials>();
            ProductCostHistories = new HashSet<ProductCostHistory>();
            ProductInventories = new HashSet<ProductInventory>();
            ProductListPriceHistories = new HashSet<ProductListPriceHistory>();
            ProductProductPhotos = new HashSet<ProductProductPhoto>();
            ProductReviews = new HashSet<ProductReview>();
            ProductVendors = new HashSet<ProductVendor>();
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            ShoppingCartItems = new HashSet<ShoppingCartItem>();
            SpecialOfferProducts = new HashSet<SpecialOfferProduct>();
            TransactionHistories = new HashSet<TransactionHistory>();
            WorkOrders = new HashSet<WorkOrder>();

            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ProductID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductID'.
        /// </value>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductNumber'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductNumber'.
        /// </value>
        public string ProductNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MakeFlag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MakeFlag'.
        /// </value>
        public bool MakeFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FinishedGoodsFlag'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FinishedGoodsFlag'.
        /// </value>
        public bool FinishedGoodsFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Color'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Color'.
        /// </value>
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SafetyStockLevel'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SafetyStockLevel'.
        /// </value>
        public short SafetyStockLevel { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ReorderPoint'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ReorderPoint'.
        /// </value>
        public short ReorderPoint { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'StandardCost'.
        /// </summary>
        /// <value>
        /// The property value representing column 'StandardCost'.
        /// </value>
        public decimal StandardCost { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ListPrice'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ListPrice'.
        /// </value>
        public decimal ListPrice { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Size'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Size'.
        /// </value>
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SizeUnitMeasureCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SizeUnitMeasureCode'.
        /// </value>
        public string SizeUnitMeasureCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WeightUnitMeasureCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WeightUnitMeasureCode'.
        /// </value>
        public string WeightUnitMeasureCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Weight'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Weight'.
        /// </value>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DaysToManufacture'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DaysToManufacture'.
        /// </value>
        public int DaysToManufacture { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductLine'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductLine'.
        /// </value>
        public string ProductLine { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Class'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Class'.
        /// </value>
        public string Class { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Style'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Style'.
        /// </value>
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductSubcategoryID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductSubcategoryID'.
        /// </value>
        public int? ProductSubcategoryID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductModelID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductModelID'.
        /// </value>
        public int? ProductModelID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SellStartDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SellStartDate'.
        /// </value>
        public DateTime SellStartDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SellEndDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SellEndDate'.
        /// </value>
        public DateTime? SellEndDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DiscontinuedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DiscontinuedDate'.
        /// </value>
        public DateTime? DiscontinuedDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'rowguid'.
        /// </summary>
        /// <value>
        /// The property value representing column 'rowguid'.
        /// </value>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public DateTime ModifiedDate { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="BillOfMaterials" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="BillOfMaterials" />.
        /// </value>
        public virtual ICollection<BillOfMaterials> AssemblyBillOfMaterials { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="BillOfMaterials" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="BillOfMaterials" />.
        /// </value>
        public virtual ICollection<BillOfMaterials> ComponentBillOfMaterials { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="ProductCostHistory" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductCostHistory" />.
        /// </value>
        public virtual ICollection<ProductCostHistory> ProductCostHistories { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="ProductInventory" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductInventory" />.
        /// </value>
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="ProductListPriceHistory" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductListPriceHistory" />.
        /// </value>
        public virtual ICollection<ProductListPriceHistory> ProductListPriceHistories { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="ProductModel" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="ProductModel" />.
        /// </value>
        /// <seealso cref="ProductModelID" />
        public virtual ProductModel ProductModel {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="ProductProductPhoto" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductProductPhoto" />.
        /// </value>
        public virtual ICollection<ProductProductPhoto> ProductProductPhotos { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="ProductReview" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductReview" />.
        /// </value>
        public virtual ICollection<ProductReview> ProductReviews { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="ProductSubcategory" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="ProductSubcategory" />.
        /// </value>
        /// <seealso cref="ProductSubcategoryID" />
        public virtual ProductSubcategory ProductSubcategory {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="ProductVendor" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ProductVendor" />.
        /// </value>
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="PurchaseOrderDetail" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="PurchaseOrderDetail" />.
        /// </value>
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="ShoppingCartItem" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="ShoppingCartItem" />.
        /// </value>
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="UnitMeasure" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="UnitMeasure" />.
        /// </value>
        /// <seealso cref="SizeUnitMeasureCode" />
        public virtual UnitMeasure SizeUnitMeasure {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="SpecialOfferProduct" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="SpecialOfferProduct" />.
        /// </value>
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }

        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TransactionHistory" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TransactionHistory" />.
        /// </value>
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="UnitMeasure" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="UnitMeasure" />.
        /// </value>
        /// <seealso cref="WeightUnitMeasureCode" />
        public virtual UnitMeasure WeightUnitMeasure {get; set; }
        
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="WorkOrder" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="WorkOrder" />.
        /// </value>
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }

        #endregion // Generated Relationships
    }
}
