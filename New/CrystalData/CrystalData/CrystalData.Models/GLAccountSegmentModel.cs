using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("GLAccountSegment")]
    public class GLAccountSegmentModel
    {
        public Int32 Number { get; set; } 
        public string Description { get; set; }
        public string Type { get; set; }
        public Int32? Length { get; set; }
        public Int32? SegType { get; set; }
        public string ConstantSalesValue { get; set; }
        public string ConstantReturnsValue { get; set; }
        public string ConstantTradeDiscountValue { get; set; }
        public string ConstantCOGSValue { get; set; }
        public string TaxableSalesValue { get; set; }
        public string TaxableReturnsValue { get; set; }
        public string TaxableTradeDiscountValue { get; set; }
        public string NontaxableSalesValue { get; set; }
        public string NontaxableReturnsValue { get; set; }
        public string NontaxableTradeDiscountValue { get; set; }
        public string TaxableCOGSValue { get; set; }
        public string NontaxableCOGSValue { get; set; }
    }
}
