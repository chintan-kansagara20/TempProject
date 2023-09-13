using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbEDICreditDetail")]
    public class tbEDICreditDetailModel
    {
        public Int32 PKIDEDICreditDetail { get; set; } 
        public string CreditID { get; set; }
        public string CreditDate { get; set; }
        public string AdjustmentReason { get; set; }
        public string CreditDebit { get; set; }
        public string LineNumber { get; set; }
        public string Amount { get; set; }
        public string Quantity { get; set; }
        public string Unit { get; set; }
        public string UnitPrice { get; set; }
        public string Message { get; set; }
        public string BuyerItemID { get; set; }
        public string UPC { get; set; }
        public string VendorProductID { get; set; }
        public string CrossRefCode { get; set; }
        public Boolean Posted { get; set; } = true;
        public string ACCTivateOrderNumber { get; set; }
    }
}
