using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductAltID")]
    public class ProductAltIDModel
    {
        public Guid GUIDProduct { get; set; } 
        public string ProductID { get; set; } 
        public string AlternateProductID { get; set; }
        public string Description { get; set; }
        public string UPC { get; set; }
    }
}
