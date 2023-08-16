using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductWarehouseLastVoidedDate")]
    public class ProductWarehouseLastVoidedDateModel
    {
        public Guid? GUIDWarehouse { get; set; }
        public Guid GUIDProduct { get; set; } 
        public DateTime? LastVoidedDate { get; set; }
    }
}
