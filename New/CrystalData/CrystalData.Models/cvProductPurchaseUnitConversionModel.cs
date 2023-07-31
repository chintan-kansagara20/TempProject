using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductPurchaseUnitConversion")]
    public class cvProductPurchaseUnitConversionModel
    {
        public string ProductID { get; set; } 
        public Guid GUIDProduct { get; set; } 
        public Decimal PurchaseUnitFactor { get; set; } 
        public string PurchaseUnit { get; set; }
        public string StockingUnit { get; set; }
    }
}
