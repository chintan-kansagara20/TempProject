using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvSuppManufacture")]
    public class cvSuppManufactureModel
    {
        public Int32? RegNumber { get; set; }
        public Int32? FAssyRegNum { get; set; }
        public DateTime? FAssyTransactionDate { get; set; }
        public string AODescription { get; set; }
        public string FProductDescription { get; set; }
        public Decimal? FAssyOrderQty { get; set; }
        public Decimal? FAssyEstQty { get; set; }
        public Decimal? FAssyActualQty { get; set; }
        public Decimal? UnLabelledEstQty { get; set; }
        public Decimal? UnLabelledActQty { get; set; }
        public string FAssyUnit { get; set; }
        public Guid? FAssyCustOrderLineGUID { get; set; }
        public string OrderNumber { get; set; }
        public string FAssyCustName { get; set; }
        public string FassyCustPO { get; set; }
        public DateTime? FassyCustRequestDate { get; set; }
        public string BlendProductType { get; set; }
        public string BlendProductTypeDescription { get; set; }
        public string Warnings { get; set; }
        public Decimal? BlendOrderQty { get; set; }
        public Decimal? BlendEstQty { get; set; }
        public Decimal? BlendEstWeightKG { get; set; }
        public Decimal? BlendActualQty { get; set; }
        public string BlendLotNumber { get; set; }
        public string BlendLotSpecification { get; set; }
        public Decimal? BlendMeasuredWeightKG { get; set; }
        public Decimal? BlendActualLotWeightKG { get; set; }
        public Decimal? BlendYieldFromServLotWeight { get; set; }
        public Guid? BlendLotSerialGUID { get; set; }
        public Decimal? FAssyEstCost { get; set; }
        public Decimal? FAssyActualCost { get; set; }
        public Decimal? FAssyEstEach { get; set; }
        public Decimal? FAssyActualEach { get; set; }
        public Decimal? FProductWeight { get; set; }
        public Decimal? ServingsPerContainer { get; set; }
        public Decimal? FProductOverage { get; set; }
        public Decimal? UnitsPerContainer { get; set; }
        public Decimal? UnitOrderQty { get; set; }
        public Decimal? UnitEstQty { get; set; }
        public Decimal? UnitsExpectedFromServLotWeight { get; set; }
        public Decimal? UnitActualQty { get; set; }
        public Decimal? UnitFillWeightGM { get; set; }
        public Decimal? UnitWeightGM { get; set; }
        public Decimal? UnitAverageMeasuredGM { get; set; }
        public Decimal? UnitLotWeightKG { get; set; }
        public string BlendDescription { get; set; }
        public Decimal? UnitsPerServing { get; set; }
        public string FAssyLotNumber { get; set; }
        public string FAssyLotSpec { get; set; }
        public DateTime? FAssyLotExpirationDate { get; set; }
        public string FAssyLotReference { get; set; }
        public string FAssyWarehouseID { get; set; }
        public Int32? PKIDINVTransaction { get; set; }
        public string AOReference { get; set; }
        public string AODocument { get; set; }
        public DateTime? AOTransactionDate { get; set; }
        public Int32? FAssyPKIDINVTransactionDetail { get; set; }
        public Int32? FAssyTransactionNumber { get; set; }
        public string ProductIdFG { get; set; }
        public string ProductIdUnit { get; set; }
        public string ProductIdBlend { get; set; }
        public string ProductIdUnlabelled { get; set; }
        public string ProductIdContainer { get; set; }
        public Guid? GUIDProductFG { get; set; }
        public Guid? GUIDProductUnit { get; set; }
        public Guid? GUIDProductBlend { get; set; }
        public Guid? GUIDProductUnlabelled { get; set; }
        public Guid? GUIDProductContainer { get; set; }
        public Int32? AOSession { get; set; }
        public string AOProductCategory { get; set; }
        public string AOProductCategoryID { get; set; }
        public Int32? SpecGroup { get; set; }
        public Int32? CompSession { get; set; }
        public Int32? CompTransactionNumber { get; set; }
        public DateTime? CompTransactionDate { get; set; }
        public string CompProductId { get; set; }
        public string CompProductDescription { get; set; }
        public string CompProductAltDescription { get; set; }
        public string CompParentProductId { get; set; }
        public Int32? RowBOMSequence { get; set; }
        public string CompLotNumber { get; set; }
        public string CompLotSpec { get; set; }
        public DateTime? CompLotExpirationDate { get; set; }
        public string CompLotReference { get; set; }
        public Decimal? CompLotPotency { get; set; }
        public string CompWarehouseID { get; set; }
        public Decimal? CompEachQty { get; set; }
        public Decimal? CompEachKAdjustQty { get; set; }
        public string CompKAdjustUnit { get; set; }
        public Decimal? CompStdQty { get; set; }
        public Decimal? CompPickQty { get; set; }
        public Decimal? CompActualQty { get; set; }
        public string CompUnit { get; set; }
        public string CompPurchaseUnit { get; set; }
        public string CompPackageUnit { get; set; }
        public Decimal? AnalyteSpecQty { get; set; }
        public Decimal? AnalyteTargetQty { get; set; }
        public string AnalyteUnit { get; set; }
        public string CompTechSpec { get; set; }
        public string CompCleanNote { get; set; }
        public string CompBeforeNote { get; set; }
        public Decimal? CompUnitWeightGM { get; set; }
        public Decimal? CompPctOfFillWeight { get; set; }
        public Boolean? CompProductAdjustForPotency { get; set; }
        public Decimal? CompProductPotency { get; set; }
        public string CompProductCategory { get; set; }
        public string CompProductCategoryID { get; set; }
        public string CompProductType { get; set; }
        public Int32? CompProductNonActiveIng { get; set; }
        public Decimal? CompProductOverage { get; set; }
        public Decimal? PriceUnitFactor { get; set; }
        public Decimal? AnalyteUnitFactor { get; set; }
        public string CompPriceUnit { get; set; }
        public Decimal? CompPrice { get; set; }
        public Decimal? CompEstCost { get; set; }
        public Decimal? CompActualCost { get; set; }
        public Int32? AOTransactionNumber { get; set; }
        public Guid? GUIDINVTransactionDetail { get; set; }
        public Int32? PKIDINVTransactionComponent { get; set; }
        public Int32? PKIDINVRegister { get; set; }
        public Guid? GUIDINVParentTransactionDetail { get; set; }
        public Guid? GUIDCompProduct { get; set; }
        public Guid? GUIDCompParentProduct { get; set; }
        public Guid? GUIDLotSerial { get; set; }
        public Guid? GUIDWhLocation { get; set; }
    }
}
