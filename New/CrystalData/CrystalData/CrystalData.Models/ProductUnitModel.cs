using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductUnit")]
    public class ProductUnitModel
    {
        public string BaseUnit { get; set; } 
        public string Unit { get; set; } 
        public Decimal? Factor { get; set; }
        public string FactorBasis { get; set; }
        public string Basis { get; set; }
        public Boolean Active { get; set; }
        public Boolean Discrete { get; set; }
    }
}
