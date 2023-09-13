using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductComponent")]
    public class cvProductComponentModel
    {
        public Guid GUIDProductComponent { get; set; } 
        public Guid GUIDProduct { get; set; } 
        public string ComponentType { get; set; }
        public Guid ComponentGUIDProduct { get; set; } 
        public Guid? GUIDComponentWarehouse { get; set; }
        public Decimal? Quantity { get; set; }
        public Boolean VariableQuantity { get; set; }
        public Decimal? Cost { get; set; }
        public Int32? Sequence { get; set; }
        public string Note { get; set; }
        public string ProductID { get; set; }
        public string ComponentProductID { get; set; }
        public string ComponentWarehouse { get; set; }
        public string CleanNote { get; set; }
        public string BeforeNote { get; set; }
        public string RecipeNote { get; set; }
    }
}
