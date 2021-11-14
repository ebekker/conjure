#pragma warning disable IDE0073 // The file header is missing or not located at the top of the file
/** THIS IS AUTOGENERATED BY CONJURE EFX **/
#pragma warning restore IDE0073 // The file header is missing or not located at the top of the file

using System;
using System.Collections.Generic;

namespace ConjureApp.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'vProductModelCatalogDescription'
    /// </summary>
    public partial class VProductModelCatalogDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VProductModelCatalogDescription"/> class.
        /// </summary>
        public VProductModelCatalogDescription()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'ProductModelID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductModelID'.
        /// </value>
        public virtual int ProductModelID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name'.
        /// </value>
        public virtual string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the property value representing column 'Summary'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Summary'.
        /// </value>
        public virtual string? Summary { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Manufacturer'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Manufacturer'.
        /// </value>
        public virtual string? Manufacturer { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Copyright'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Copyright'.
        /// </value>
        public virtual string? Copyright { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductURL'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductURL'.
        /// </value>
        public virtual string? ProductURL { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WarrantyPeriod'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WarrantyPeriod'.
        /// </value>
        public virtual string? WarrantyPeriod { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WarrantyDescription'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WarrantyDescription'.
        /// </value>
        public virtual string? WarrantyDescription { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NoOfYears'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NoOfYears'.
        /// </value>
        public virtual string? NoOfYears { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MaintenanceDescription'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MaintenanceDescription'.
        /// </value>
        public virtual string? MaintenanceDescription { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Wheel'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Wheel'.
        /// </value>
        public virtual string? Wheel { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Saddle'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Saddle'.
        /// </value>
        public virtual string? Saddle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Pedal'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Pedal'.
        /// </value>
        public virtual string? Pedal { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BikeFrame'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BikeFrame'.
        /// </value>
        public virtual string? BikeFrame { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Crankset'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Crankset'.
        /// </value>
        public virtual string? Crankset { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PictureAngle'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PictureAngle'.
        /// </value>
        public virtual string? PictureAngle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PictureSize'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PictureSize'.
        /// </value>
        public virtual string? PictureSize { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductPhotoID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductPhotoID'.
        /// </value>
        public virtual string? ProductPhotoID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Material'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Material'.
        /// </value>
        public virtual string? Material { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Color'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Color'.
        /// </value>
        public virtual string? Color { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProductLine'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProductLine'.
        /// </value>
        public virtual string? ProductLine { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Style'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Style'.
        /// </value>
        public virtual string? Style { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RiderExperience'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RiderExperience'.
        /// </value>
        public virtual string? RiderExperience { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'rowguid'.
        /// </summary>
        /// <value>
        /// The property value representing column 'rowguid'.
        /// </value>
        public virtual Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public virtual DateTime ModifiedDate { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}