using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("TaxCategory")]
    public class TaxCategoryModel
    {
        public string TaxCatId { get; set; } 
        public string Description { get; set; }
        public Boolean? Status { get; set; }
        public Boolean ExemptForFreight { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid GUIDTaxCategory { get; set; } 
        public string TaxCatListID { get; set; } 
    }
}
