using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("LotSerialDefaultLocation")]
    public class LotSerialDefaultLocationModel
    {
        public Guid GUIDProduct { get; set; } 
        public Guid? GUIDWarehouse { get; set; }
        public string ProductID { get; set; } 
        public string WarehouseID { get; set; }
        public string LotNumber { get; set; }
        public Guid? DefaultGUIDWHLocation { get; set; }
        public string DefaultLocation { get; set; }
        public Int32? IsStockedInPrimary { get; set; }
    }
}
