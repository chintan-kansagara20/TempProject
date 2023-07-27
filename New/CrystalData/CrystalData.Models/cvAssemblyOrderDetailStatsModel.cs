using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyOrderDetailStats")]
    public class cvAssemblyOrderDetailStatsModel
    {
        public Int32? Session { get; set; }
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
        public Decimal? AssemblyDetQtyUsed { get; set; }
        public Decimal? AssemblyDetQtyRequired { get; set; }
        public string unit { get; set; }
        public Decimal? OnHand { get; set; }
        public Decimal? Available { get; set; }
        public Decimal? Transfer { get; set; }
        public DateTime? LastReceiptDate { get; set; }
        public Decimal? QCQtyOnHand { get; set; }
        public Decimal? ProdQtyOnHand { get; set; }
        public Decimal? OnHandAllWarehouses { get; set; }
        public Decimal? AvailableAllWarehouses { get; set; }
        public Decimal? TransferAllWarehouses { get; set; }
        public string PurchaseUnit { get; set; }
        public Decimal? PurchaseUnitFactor { get; set; }
        public Decimal? POQtyOutstanding { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
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
        public Guid? CompGUIDProduct { get; set; }
        public Guid GUIDINVTransactionDetail { get; set; } 
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
    }
}
