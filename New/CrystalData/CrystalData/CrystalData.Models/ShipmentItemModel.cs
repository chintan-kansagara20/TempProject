using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ShipmentItem")]
    public class ShipmentItemModel
    {
        public string ShipmentNumber { get; set; }
        public string ShipmentStatus { get; set; }
        public string ShipmentStatusDescription { get; set; }
        public Int32? PackNumber { get; set; }
        public string PackageID { get; set; }
        public string OrderNumber { get; set; } 
        public Int32? OrderLineNumber { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string Warehouse { get; set; }
        public Guid GUIDShipmentItem { get; set; } 
        public Guid GUIDShipmentOrder { get; set; } 
        public Guid GUIDOrderDetail { get; set; } 
        public Guid? GUIDShipmentPack { get; set; }
        public Int32? LineNumber { get; set; }
        public Decimal? QtyShipped { get; set; }
    }
}
