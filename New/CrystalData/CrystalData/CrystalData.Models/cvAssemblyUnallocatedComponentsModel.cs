using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyUnallocatedComponents")]
    public class cvAssemblyUnallocatedComponentsModel
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
        public Decimal? OrderQuantity { get; set; }
        public string unit { get; set; }
        public string PurchaseUnit { get; set; }
        public Decimal? PrdQtyOnHand { get; set; }
        public Decimal? PrdAvailable { get; set; }
        public Decimal? QCQtyOnHand { get; set; }
        public Decimal? Allocated { get; set; }
        public Decimal? QtyOnOrder { get; set; }
        public Decimal? EffectivePrice { get; set; }
        public DateTime? LastReceiptDate { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
        public Int32? LeadTime { get; set; }
        public string VendorName { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string InventoryControlType { get; set; }
        public string ProductCategory { get; set; }
        public string ProductCategoryID { get; set; }
        public Guid? CompGUIDProduct { get; set; }
        public Guid GUIDINVTransactionDetail { get; set; } 
    }
}
