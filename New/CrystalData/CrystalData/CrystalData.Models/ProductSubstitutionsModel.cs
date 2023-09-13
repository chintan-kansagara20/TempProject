using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductSubstitutions")]
    public class ProductSubstitutionsModel
    {
        public Guid GUIDProductSubstitution { get; set; }
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDSubstitution { get; set; }
        public Boolean Preferred { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Reference { get; set; }
        public string Note { get; set; }
        public string ProductID { get; set; } 
        public string ProductDescription { get; set; }
        public string SubstitutionID { get; set; } 
        public string SubstitutionDescription { get; set; }
    }
}
