using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvReceiptTransactionDetail")]
    public class cvReceiptTransactionDetailModel
    {
        public Int32? Session { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public Int32? TransactionLine { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string PONumber { get; set; }
        public Int32? POLineNumber { get; set; }
        public string Reference { get; set; }
        public string Document { get; set; }
        public Int32? DocumentNum { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string TrxDescription { get; set; }
        public string VendorID { get; set; }
        public string VendorName { get; set; }
        public string ProductId { get; set; }
        public string ProductDescription { get; set; }
        public string _StorageConditions { get; set; }
        public Decimal? Quantity { get; set; }
        public Decimal? ReceiptAmount { get; set; }
        public Decimal? ProductUnitCost { get; set; }
        public string Note { get; set; }
        public string ProductUnit { get; set; }
        public string ReceiptUnit { get; set; }
        public Decimal? ReceiptQuantity { get; set; }
        public Decimal? ReceiptUnitFactor { get; set; }
        public Decimal? ReceiptUnitCost { get; set; }
        public Double? Pallets { get; set; }
        public Double? PartialPallet { get; set; }
        public Double? QuantityPerPallet { get; set; }
        public Double? Containers { get; set; }
        public Double? PartialContainer { get; set; }
        public Double? QuantityPerContainer { get; set; }
        public string ProductCategoryId { get; set; }
        public Decimal? ProductSpecGroup { get; set; }
        public string ProductType { get; set; }
        public string ProductSalesCategory { get; set; }
        public string StorageConditions { get; set; }
        public string ProductCategory { get; set; }
        public string AlternateProductID { get; set; }
        public string UPC { get; set; }
        public string LotNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string LotReference { get; set; }
        public string LotSpecification { get; set; }
        public string WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseLocation { get; set; }
        public Guid? RectGuidProduct { get; set; }
        public Byte? PostedToGL { get; set; }
        public Byte? PostedToINV { get; set; }
        public Int32 parent { get; set; } 
        public Int32? NumSiblings { get; set; }
        public string PurchUnit { get; set; }
        public Decimal? PurchUnitQtyRecived { get; set; }
        public Decimal QuantityPerPurchaseUnit { get; set; } 
        public Decimal? PurchUnitCost { get; set; }
        public Guid GUIDINVTransaction { get; set; } 
        public Int32? PKIDINVTransactionDetail { get; set; }
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDPODetail { get; set; }
        public Guid? GUIDPO { get; set; }
        public Guid? GUIDVendor { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDINVTransactionDetail { get; set; }
    }
}
