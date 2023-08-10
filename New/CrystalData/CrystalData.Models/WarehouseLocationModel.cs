using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("WarehouseLocation")]
    public class WarehouseLocationModel
    {
        public string Warehouse { get; set; }
        public string WarehouseDescription { get; set; }
        public Guid GUIDWHLocation { get; set; }
        public Guid GUIDWarehouse { get; set; }
        public string Description { get; set; }
        public Int32? Sequence { get; set; }
        public string Zone { get; set; }
        public Boolean Active { get; set; }
        public string Group { get; set; }
    }
}
