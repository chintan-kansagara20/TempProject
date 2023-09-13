using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbProduct")]
    public class tbProductModel
    {
        public string ProductID { get; set; }
        public Guid? SalesGUIDTaxCode { get; set; }
        public Guid? PurchaseGUIDTaxCode { get; set; }
        public Boolean TaxByCategory { get; set; } = true;
        public Guid? GUIDTaxCategory { get; set; }
        public Boolean TaxInPrice { get; set; } = true;
        public Boolean AllowOverride { get; set; } = true;
        public Boolean AllowZero { get; set; } = true;
        public Int16? CommissionType { get; set; }
        public Decimal? CommPct { get; set; }
        public Decimal? CommAmt { get; set; }
        public string Unit { get; set; }
        public Decimal? Weight { get; set; }
        public Decimal? Length { get; set; }
        public Boolean VariableWeight { get; set; } = true;
        public Boolean VariableLength { get; set; } = true;
        public string Specification { get; set; }
        public string ProductPriceCategory { get; set; }
        public Boolean PriceByCategory { get; set; } = true;
        public Guid? GUIDProductClass { get; set; }
        public Int32? LeadTime { get; set; }
        public string SalesCategory { get; set; }
        public Boolean Discontinued { get; set; } = true;
        public string CostMethod { get; set; }
        public string ProductType { get; set; }
        public string InventoryControlType { get; set; }
        public string AssemblyType { get; set; }
        public string CountCycle { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Boolean Status { get; set; } = true;
        public string Note { get; set; }
        public Boolean Popup { get; set; } = true;
        public string PONote { get; set; }
        public Boolean POPopup { get; set; } = true;
        public string Color { get; set; }
        public Decimal? Height { get; set; }
        public string Size { get; set; }
        public Boolean VariableHeight { get; set; } = true;
        public Boolean VariableVolume { get; set; } = true;
        public Boolean VariableWidth { get; set; } = true;
        public Decimal? Volume { get; set; }
        public Decimal? Width { get; set; }
        public string TechSpec { get; set; }
        public string WebAddress { get; set; }
        public string AltDescription { get; set; }
        public string Description { get; set; }
        public Guid GUIDProduct { get; set; }
        public Boolean NotForResale { get; set; } = true;
        public Int32 MaintainInventoryType { get; set; } = ((0));
        public Boolean AvailOnWeb { get; set; } = true;
        public Byte[]? ProductPicture { get; set; }
        public Boolean ShipCompleteLots { get; set; } = true;
        public Decimal? AltWeight { get; set; }
        public Decimal? AltLength { get; set; }
        public Decimal? AltHeight { get; set; }
        public Decimal? AltWidth { get; set; }
        public Decimal? AltVolume { get; set; }
        public Decimal? AltUnitsPerPalletLayer { get; set; }
        public Decimal? PalletLayers { get; set; }
        public Decimal? InnerPackQty { get; set; }
        public Decimal? OuterPackQty { get; set; }
        public Boolean Discountable { get; set; } = true;
        public string SalesUnit { get; set; }
        public string PurchaseUnit { get; set; }
        public string PackageUnit { get; set; }
        public Decimal? LandedCostFactor { get; set; }
        public Decimal? _WeightVarAvgToLabel { get; set; }
        public string _Allergens { get; set; }
        public string _ShelfLife { get; set; }
        public Boolean _EssentialQcSpecs { get; set; } = true;
        public string _BlendType { get; set; }
        public Boolean _Analytic { get; set; } = true;
        public string _AllergenSeverity { get; set; }
        public string _SubcontractMfg { get; set; }
        public string _Composition { get; set; }
        public string _ServingOccasion { get; set; }
        public string _LotLabelType { get; set; }
        public Decimal? _ServingsPerContainer { get; set; }
        public string _LotNumLocation { get; set; }
        public Boolean _InactiveIngredient { get; set; } = true;
        public string _ServingDescription { get; set; }
        public string _CustomProductCategory { get; set; }
        public Decimal? _MfgOverage { get; set; }
        public string _Taste { get; set; }
        public Boolean _NoSubassemblies { get; set; } = true;
        public string _Scent { get; set; }
        public Boolean _Control { get; set; } = true;
        public string _GlutenRating { get; set; }
        public Boolean _OptionalManufacturingSpecs { get; set; } = true;
        public string _ConsumerWarnings { get; set; }
        public Decimal? _ProjectionQty { get; set; }
        public string _LabelClaims { get; set; }
        public Decimal? _ServingsPerDay { get; set; }
        public string _ControlMethod { get; set; }
        public string _ControlSpec { get; set; }
        public string _ControlDataType { get; set; }
        public string _CountryOrigin { get; set; }
        public Decimal? _WeightVarIndivToAvg { get; set; }
        public string _Dissolution { get; set; }
        public string _Appearance { get; set; }
        public Decimal? _ControlMax { get; set; }
        public string _ControlGroup { get; set; }
        public string _StorageConditions { get; set; }
        public Decimal? _ControlMin { get; set; }
        public Decimal? _MaxBatchSize { get; set; }
        public Decimal? _UnitsPerServing { get; set; }
        public string _Analyte { get; set; }
        public string _PackSize { get; set; }
        public Boolean _AdjustForPotency { get; set; } = true;
        public Boolean _CreateSubActivities { get; set; } = true;
        public Decimal? _Potency { get; set; }
        public Boolean _EssentialManufacturingSpecs { get; set; } = true;
        public Boolean _OptionalQCSpecs { get; set; } = true;
        public Boolean _Pricing { get; set; } = true;
        public Decimal? _PerUnitLabor { get; set; }
        public Decimal? _PerJobFreight { get; set; }
        public Decimal? _PerJobOther { get; set; }
        public Decimal? _WastePercent { get; set; }
        public Decimal? _PerUnitMachineOther { get; set; }
        public Decimal? _ProfitMarginPercent { get; set; }
        public string _ControlActivityStatus { get; set; }
        public string _ControlActivityType { get; set; }
        public string _ControlAssignTo { get; set; }
        public Decimal? _HoursToComplete { get; set; }
        public Decimal? _OuterPacksPerPallet { get; set; }
        public string _PalletStackingInstructions { get; set; }
        public string _ControlOrderWorkflowStatus { get; set; }
        public string _ControlProductionWorkflow { get; set; }
        public string _ControlOutput { get; set; }
    }
}
