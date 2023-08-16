using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductSupplier")]
    public class ProductSupplierModel
    {
        public Guid GUIDProductSupplier { get; set; }
        public Guid GUIDProduct { get; set; } 
        public string ProductID { get; set; }
        public Guid? GUIDVendor { get; set; }
        public string VendorID { get; set; }
        public string VendorProductID { get; set; }
        public Decimal? VendorPrice { get; set; }
        public string Unit { get; set; }
        public Boolean Preferred { get; set; }
        public Int32? LeadTime { get; set; }
        public string LastPO { get; set; }
        public DateTime? LastPurchaseDate { get; set; }
        public Decimal? LastPurchaseQty { get; set; }
        public Decimal? LastPurchasePrice { get; set; }
        public string LastPurchaseUnit { get; set; }
        public DateTime? LastReceiptDate { get; set; }
        public Decimal? LastReceiptQty { get; set; }
        public Decimal? LastPrice { get; set; }
        public string LastReceiptUnit { get; set; }
        public string Note { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
    }
}
