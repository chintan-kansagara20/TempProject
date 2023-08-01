using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbProductComponent")]
    public class tbProductComponentModel
    {
        public Guid GUIDProductComponent { get; set; }
        public Guid GUIDProduct { get; set; }
        public string ComponentType { get; set; }
        public Guid ComponentGUIDProduct { get; set; }
        public Guid? GUIDComponentWarehouse { get; set; }
        public Decimal? Quantity { get; set; }
        public Boolean VariableQuantity { get; set; } = true;
        public Decimal? Cost { get; set; }
        public Int32? Sequence { get; set; }
        public string Note { get; set; }
    }
}
