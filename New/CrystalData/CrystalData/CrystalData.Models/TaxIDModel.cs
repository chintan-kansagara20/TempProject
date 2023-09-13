using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("TaxID")]
    public class TaxIDModel
    {
        public string TaxId { get; set; } 
        public string Description { get; set; }
        public string TaxType { get; set; }
        public Boolean? ApplyToFreight { get; set; }
        public Boolean? ApplytoFinChg { get; set; }
        public Boolean? Taxable { get; set; }
        public string TaxableBy { get; set; }
        public Guid? GUIDGLAccrualAccount { get; set; }
        public Decimal? TaxRate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public Int32? RptBasis { get; set; }
        public Boolean? Status { get; set; }
        public Boolean? Printed { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid GUIDTaxID { get; set; } 
        public string TaxItemListID { get; set; }
        public Guid? GUIDTaxVendor { get; set; }
        public string GLAccrualAccountId { get; set; }
    }
}
