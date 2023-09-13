using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductVendorPrice")]
    public class cvProductVendorPriceModel
    {
        public string ProductID { get; set; } 
        public string VendorName { get; set; }
        public Boolean? Preferred { get; set; }
        public string VendorProductID { get; set; }
        public Int32? LeadTime { get; set; }
        public Decimal? VendorPrice { get; set; }
        public string Unit { get; set; }
        public Decimal? EffectivePrice { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string PriceUnit { get; set; }
        public Decimal PriceFactor { get; set; } 
        public DateTime? LastReceiptDate { get; set; }
        public Decimal? LastReceiptQty { get; set; }
        public Decimal? LastPrice { get; set; }
        public string LastReceiptUnit { get; set; }
        public string Note { get; set; }
        public Guid GUIDProduct { get; set; } 
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDVendor { get; set; }
    }
}
