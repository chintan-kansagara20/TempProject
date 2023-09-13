using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductAltUnit")]
    public class ProductAltUnitModel
    {
        public Decimal? Factor { get; set; }
        public string Basis { get; set; }
        public string StockingUnits { get; set; }
        public string Unit { get; set; }
        public string ProductID { get; set; }
        public Boolean Active { get; set; }
        public Boolean Discrete { get; set; }
        public string FactorBasis { get; set; }
        public Guid? GUIDProduct { get; set; }
    }
}
