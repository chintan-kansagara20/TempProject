using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyOrderDetail")]
    public class cvAssemblyOrderDetailModel
    {
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Document { get; set; }
        public Int32? DocumentNumber { get; set; }
        public Int32? CompRegNumber { get; set; }
        public Int32? CompTransactionNumber { get; set; }
        public string TransactionType { get; set; }
        public string CompProductId { get; set; }
        public string CompProductDescription { get; set; }
        public Decimal? CompQuantity { get; set; }
        public Decimal? CompPlannedQuantity { get; set; }
        public string CompUnit { get; set; }
        public string CompLotNumber { get; set; }
        public string CompLotSpec { get; set; }
        public DateTime? CompLotExpirationDate { get; set; }
        public string CompLotReference { get; set; }
        public Double? CompLotPotency { get; set; }
        public Decimal? CompPrice { get; set; }
        public string VendorName { get; set; }
        public string VendorPriceUnit { get; set; }
        public Decimal? VendorPriceFactor { get; set; }
        public string CompPriceUnit { get; set; }
        public Decimal? BatchCost { get; set; }
        public string BatchParent { get; set; }
        public Decimal CompPriceUnitFactor { get; set; }
        public string ProductCategory { get; set; }
        public string CompProductCategoryId { get; set; }
        public Int32? AOProductSpecGroup { get; set; }
        public string ProductType { get; set; }
        public string ProductClassID { get; set; }
        public Guid? GUIDProductClass { get; set; }
        public Guid CompGUIDProduct { get; set; }
        public Guid? CompGuidWhLocation { get; set; }
        public string FProductDescription { get; set; }
        public string FProductID { get; set; }
        public Decimal? FGQuantity { get; set; }
        public Boolean PostedToINV { get; set; }
        public string VoidedBy { get; set; }
        public Int32? FGTrxRegNum { get; set; }
        public Int32 PKIDINVTransactionDetail { get; set; } 
        public Guid GUIDINVTransactionDetail { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public Guid GUIDINVTransaction { get; set; } 
        public Guid? FProductGUIDProduct { get; set; }
    }
}
