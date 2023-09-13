using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductWarehouseLocation")]
    public class ProductWarehouseLocationModel
    {
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public Int32 MaintainInventoryType { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string WarehouseID { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public string Description { get; set; }
        public string Zone { get; set; }
        public Int32? Sequence { get; set; }
    }
}
