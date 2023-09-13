using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductExportNSS")]
    public class cvProductExportNSSModel
    {
        public string ProductID { get; set; } 
        public string Description { get; set; }
        public string Taxable { get; set; }
        public string AlternateProductID { get; set; }
        public string AltDescription { get; set; }
        public string ItemType { get; set; }
        public string ProductClassID { get; set; }
        public string ProductClassDescription { get; set; }
        public string ProductClassIncomeAcct { get; set; }
        public string ProductClassCGSAcct { get; set; }
        public string ProductTypeID { get; set; }
        public string ProductTypeDescription { get; set; }
        public string ProductCategory { get; set; }
        public string ProductCategoryID { get; set; }
        public string SalesCategory { get; set; }
        public Decimal? Weight { get; set; }
        public Decimal? Length { get; set; }
        public Int32? LeadTime { get; set; }
        public Boolean Discontinued { get; set; }
        public string CostMethod { get; set; } 
        public string InventoryControlType { get; set; }
        public string BillOfMaterials { get; set; } 
        public string Status { get; set; }
        public string Note { get; set; }
        public Boolean Popup { get; set; }
        public string PONote { get; set; }
        public Boolean POPopup { get; set; }
        public string Color { get; set; }
        public Decimal? Height { get; set; }
        public string Size { get; set; }
        public string UPC { get; set; }
        public Decimal? Volume { get; set; }
        public Decimal? Width { get; set; }
        public string TechSpec { get; set; }
        public string WebAddress { get; set; }
        public Guid GUIDProduct { get; set; } 
        public Int32 MaintainInventoryType { get; set; } 
        public Byte[]? ProductPicture { get; set; }
        public Decimal? InnerPackQty { get; set; }
        public Decimal? OuterPackQty { get; set; }
        public string Unit { get; set; }
        public string SalesUnit { get; set; }
        public string PurchaseUnit { get; set; }
        public string PackageUnit { get; set; }
        public string Keywords { get; set; }
        public string ExternalDocument { get; set; }
        public string PreferredVendorID { get; set; }
        public Decimal? ListPrice { get; set; }
        public string ListPriceType { get; set; }
        public string ListPriceUnit { get; set; }
        public Boolean _AdjustForPotency { get; set; }
        public string _AllergenSeverity { get; set; }
        public string _allergens { get; set; }
        public string _analyte { get; set; }
        public string _appearance { get; set; }
        public string _composition { get; set; }
        public string _ConsumerWarnings { get; set; }
        public string _CountryOrigin { get; set; }
        public Boolean _CreateSubActivities { get; set; }
        public string _dissolution { get; set; }
        public string _GlutenRating { get; set; }
        public string _LabelClaims { get; set; }
        public string _LotLabelType { get; set; }
        public string _LotNumLocation { get; set; }
        public Decimal? _MaxBatchSize { get; set; }
        public Decimal? _MfgOverage { get; set; }
        public string _PackSize { get; set; }
        public Decimal? _potency { get; set; }
        public string _scent { get; set; }
        public string _ServingDescription { get; set; }
        public string _ServingOccasion { get; set; }
        public Decimal? _ServingsPerContainer { get; set; }
        public Decimal? _ServingsPerDay { get; set; }
        public string _ShelfLife { get; set; }
        public string _StorageConditions { get; set; }
        public string _SubcontractMfg { get; set; }
        public string _taste { get; set; }
        public string _ControlGroup { get; set; }
        public string _ControlDataType { get; set; }
        public Decimal? _ControlMax { get; set; }
        public string _ControlMethod { get; set; }
        public Decimal? _ControlMin { get; set; }
        public string _ControlSpec { get; set; }
        public Decimal? _UnitsPerServing { get; set; }
        public Decimal? _WeightVarAvgToLabel { get; set; }
        public Decimal? _WeightVarIndivToAvg { get; set; }
    }
}
