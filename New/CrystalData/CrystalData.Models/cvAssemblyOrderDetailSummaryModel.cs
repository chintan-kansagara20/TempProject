using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyOrderDetailSummary")]
    public class cvAssemblyOrderDetailSummaryModel
    {
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public Int32? DocumentNumber { get; set; }
        public string AOProductId { get; set; }
        public string AOProductDescription { get; set; }
        public Int32? FGTrxRegNum { get; set; }
        public string FGTrxDocument { get; set; }
        public string FGTrxDescription { get; set; }
        public string FProductID { get; set; }
        public string FProductDescription { get; set; }
        public string CompProductId { get; set; }
        public string CompProductDescription { get; set; }
        public string CompProductCategory { get; set; }
        public string CompProductCategoryID { get; set; }
        public Decimal? CompSpecGroup { get; set; }
        public Decimal? AssemblyDetQtyUsed { get; set; }
        public Decimal? AssemblyDetQtyRequired { get; set; }
        public string unit { get; set; }
        public Decimal? OnHand { get; set; }
        public Decimal? Available { get; set; }
        public DateTime? LastReceiptDate { get; set; }
        public Decimal? QCQtyOnHand { get; set; }
        public Decimal? ProdQtyOnHand { get; set; }
        public Decimal? OnHandAllWarehouses { get; set; }
        public Decimal? AvailableAllWarehouses { get; set; }
        public Decimal? SalesOrderQty { get; set; }
        public Decimal? SalesOrderQtyAllWarehouses { get; set; }
        public Decimal? UnpostedTransferQuantity { get; set; }
        public Decimal? IncomingTransferQuantity { get; set; }
        public Decimal? ReturnTransferQuantity { get; set; }
        public Decimal? UnpostedAssemblyQty { get; set; }
        public Decimal? UnpostedAssemblyQtyAllWarehouses { get; set; }
        public Decimal? UnpostedAsyComponentQty { get; set; }
        public Decimal? UnpostedAsyComponentQtyAllWarehouses { get; set; }
        public string PurchaseUnit { get; set; }
        public Decimal? PurchaseUnitFactor { get; set; }
        public Decimal? POQuantityOrdered { get; set; }
        public Decimal? POQuantityReceived { get; set; }
        public Decimal? POQuantityOnReturn { get; set; }
        public Decimal? POQtyOutstanding { get; set; }
        public DateTime? POExpectedReceiptDate { get; set; }
        public Decimal? POAmountOnOrder { get; set; }
        public Int32? LeadTime { get; set; }
        public string VendorName { get; set; }
        public Decimal? EffectivePrice { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string InventoryControlType { get; set; }
        public string ProductCategory { get; set; }
        public string ProductCategoryID { get; set; }
        public string WarehouseID { get; set; }
        public string Location { get; set; }
        public string Zone { get; set; }
        public string LotSerialNumber { get; set; }
        public string LotReference { get; set; }
        public string LotSpec { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string OriginProductSalesCategory { get; set; }
        public string OriginProductType { get; set; }
        public string OriginProductClassId { get; set; }
        public string ComponentProductSalesCategory { get; set; }
        public string ComponentProductClassId { get; set; }
        public Guid? OriginGUIDProduct { get; set; }
        public Guid? CompGUIDProduct { get; set; }
        public Guid GUIDINVTransactionDetail { get; set; } 
        public Int32 PKIDINVTransactionDetail { get; set; }
        public Int32? CountLineNumber { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public Guid? FGGUIDOrderDetail { get; set; }
        public Guid? GUIDVendor { get; set; }
    }
}
