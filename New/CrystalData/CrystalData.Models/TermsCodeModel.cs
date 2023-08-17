using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("TermsCode")]
    public class TermsCodeModel
    {
        public Guid GUIDTerms { get; set; } 
        public string TermsListID { get; set; }
        public string TermsCode { get; set; } 
        public string Description { get; set; }
        public Int32? DueDays { get; set; }
        public Int32? TypeofDueDays { get; set; }
        public Int32? DiscountDays { get; set; }
        public Decimal? DiscountPct { get; set; }
        public Int32? DueNextMonthDays { get; set; }
        public Boolean? Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
