using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductFinishedNSS")]
    public class cvProductFinishedNSSModel
    {
        public string FGProductID { get; set; } 
        public string FGDescription { get; set; }
        public string FGAlternateProductID { get; set; }
        public string FGAltDescription { get; set; }
        public string UPC { get; set; }
        public string Keywords { get; set; }
        public string FGProductClassID { get; set; }
        public string FGProductClassDescription { get; set; }
        public string FGType { get; set; } 
        public string FGTypeDescription { get; set; }
        public string FGSalesCategory { get; set; }
        public string FGSalesCategoryDescription { get; set; }
        public string FGPackSize { get; set; }
        public Decimal? FGServingsPerContainer { get; set; }
        public Decimal? FGUnitsPerServing { get; set; }
        public Decimal? FGMaxBatchSize { get; set; }
        public Boolean FGCreateSubActivities { get; set; }
        public Decimal? FGPerUnitLabor { get; set; }
        public Decimal? FGPerUnitMachineUse { get; set; }
        public Decimal? FGPerJobFreight { get; set; }
        public Decimal? FGPerJobOther { get; set; }
        public Decimal? FGWastePercent { get; set; }
        public Decimal? FGProfitMarginPercent { get; set; }
        public Boolean FGActiveStatus { get; set; }
        public string FGMetrics { get; set; } 
        public Decimal? InnerPackQty { get; set; }
        public Decimal? OuterPackQty { get; set; }
        public Decimal? _OuterPacksPerPallet { get; set; }
        public string _PalletStackingInstructions { get; set; }
        public string FGTechSpec { get; set; }
        public Decimal? FGMfgOverage { get; set; }
        public string FGSubcontractMfg { get; set; }
        public string FGLotNumberLocation { get; set; }
        public string FGLotLabelType { get; set; }
        public string FGControlMethod { get; set; }
        public string FGControlSpec { get; set; }
        public string FGShelfLife { get; set; }
        public string FGStorageConditions { get; set; }
        public string FGWeightVariation { get; set; } 
        public Decimal? FGWeightVarIndivToAvg { get; set; }
        public Decimal? FGWeightVarAvgToLabel { get; set; }
        public string FGAllergens { get; set; }
        public string FGAllergenSeverity { get; set; }
        public string FGGlutenRating { get; set; }
        public string FGWebAddress { get; set; }
        public string FGColor { get; set; }
        public string FGSize { get; set; }
        public string FGAppearance { get; set; }
        public string FGClaimsCerts { get; set; }
        public string FGScent { get; set; }
        public string FGTaste { get; set; }
        public string FGServingDescription { get; set; }
        public string FGConsumerWarnings { get; set; }
        public string FGCountryOrigin { get; set; }
        public string FGServingOccasion { get; set; }
        public Decimal? FGServingPerDay { get; set; }
        public Guid FGProductGUID { get; set; } 
        public Int32 MaintainInventoryType { get; set; } 
        public string CostMethod { get; set; } 
        public string InvntoryControlType { get; set; }
        public string BillOfMaterials { get; set; } 
        public string Status { get; set; }
        public string PriceListTable { get; set; } 
        public string PriceList { get; set; } 
    }
}
