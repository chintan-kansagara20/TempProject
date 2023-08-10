using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductCostMethod")]
    public class ProductCostMethodModel
    {
        public string CostMethod { get; set; }
        public string Description { get; set; }
        public Boolean LotSerialNumbered { get; set; }
        public Boolean Standard { get; set; }
        public Boolean Active { get; set; }
    }
}
