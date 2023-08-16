using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductType")]
    public class ProductTypeModel
    {
        public string ProductType { get; set; } 
        public string Description { get; set; }
        public Boolean Active { get; set; }
    }
}
