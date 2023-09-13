using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductEffectivePrice")]
    public class cvProductEffectivePriceModel
    {
        public string ProductID { get; set; }
        public Decimal? QuantityOrdered1 { get; set; }
        public Decimal? DisplayPrice1 { get; set; }
        public string Unit1 { get; set; }
        public DateTime? DateIssued1 { get; set; }
        public Decimal? QuantityOrdered2 { get; set; }
        public Decimal? DisplayPrice2 { get; set; }
        public string Unit2 { get; set; }
        public DateTime? DateIssued2 { get; set; }
        public Guid GUIDProduct { get; set; } 
        public Decimal? EffectivePrice { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string PriceUnit { get; set; }
        public Decimal PriceFactor { get; set; } 
        public Int32? PriceChangePercent { get; set; }
        public Guid? GUIDPODetail1 { get; set; }
        public Guid? GUIDPODetail2 { get; set; }
        public Decimal? ComponentUsage3Mo { get; set; }
        public Decimal? ComponentUsage6Mo { get; set; }
        public Decimal? ComponentUsage1Yr { get; set; }
    }
}
