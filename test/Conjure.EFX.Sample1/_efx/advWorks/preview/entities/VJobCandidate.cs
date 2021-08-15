using System;
using System.Collections.Generic;

namespace AdvWorks.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'vJobCandidate'
    /// </summary>
    public partial class VJobCandidate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VJobCandidate"/> class.
        /// </summary>
        public VJobCandidate()
        {
            #region Generated Constructor


            #endregion // Generated Constructor
        }

        #region Generated Properties

        /// <summary>
        /// Gets or sets the property value representing column 'JobCandidateID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'JobCandidateID'.
        /// </value>
        public int JobCandidateID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BusinessEntityID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BusinessEntityID'.
        /// </value>
        public int? BusinessEntityID { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name.Prefix'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name.Prefix'.
        /// </value>
        public string NamePrefix { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name.First'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name.First'.
        /// </value>
        public string NameFirst { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name.Middle'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name.Middle'.
        /// </value>
        public string NameMiddle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name.Last'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name.Last'.
        /// </value>
        public string NameLast { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Name.Suffix'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Name.Suffix'.
        /// </value>
        public string NameSuffix { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Skills'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Skills'.
        /// </value>
        public string Skills { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Addr.Type'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Addr.Type'.
        /// </value>
        public string AddrType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Addr.Loc.CountryRegion'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Addr.Loc.CountryRegion'.
        /// </value>
        public string AddrLocCountryRegion { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Addr.Loc.State'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Addr.Loc.State'.
        /// </value>
        public string AddrLocState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Addr.Loc.City'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Addr.Loc.City'.
        /// </value>
        public string AddrLocCity { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Addr.PostalCode'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Addr.PostalCode'.
        /// </value>
        public string AddrPostalCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EMail'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EMail'.
        /// </value>
        public string EMail { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WebSite'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WebSite'.
        /// </value>
        public string WebSite { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public DateTime ModifiedDate { get; set; }

        #endregion // Generated Properties

        #region Generated Relationships

        #endregion // Generated Relationships
    }
}
