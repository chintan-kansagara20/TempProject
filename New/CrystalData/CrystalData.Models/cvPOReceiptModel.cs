using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvPOReceipt")]
    public class cvPOReceiptModel
    {
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public string Warehouse { get; set; }
        public string LotNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string TransactionType { get; set; } 
        public string PONumber { get; set; }
        public Int32? POLineNumber { get; set; }
        public string Name { get; set; }
        public string TrxDescription { get; set; }
        public Decimal? QuantityReceived { get; set; }
        public string Unit { get; set; }
        public string PurchaseUnit { get; set; }
        public Decimal? PurchaseUnitFactor { get; set; }
        public Decimal? PurchUnitQtyRecived { get; set; }
        public Decimal QuantityPerPurchaseUnit { get; set; } 
        public Decimal? UnitCost { get; set; }
        public Decimal? PurchUnitCost { get; set; }
        public Decimal? AmtReceived { get; set; }
        public string Location { get; set; }
        public string note { get; set; }
        public string TrxReference { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string _storageConditions { get; set; }
        public string LotReference { get; set; }
        public string LotSpec { get; set; }
        public string AppIdProductID { get; set; }
        public string AppIdLotContainerQuantity { get; set; } 
        public string TrxNote { get; set; }
        public Double? Pallets { get; set; }
        public Double? QuantityPerPallet { get; set; }
        public string AppIdLotPalletQuantity { get; set; } 
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public Int32? TransactionLine { get; set; }
        public Int32 PKIDINVTransactionDetail { get; set; } 
        public string Document { get; set; }
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid GUIDINVTransactionDetail { get; set; } 
        public Guid? GUIDINVLotSerial { get; set; }
        public Guid? GUIDPODetail { get; set; }
    }
}
