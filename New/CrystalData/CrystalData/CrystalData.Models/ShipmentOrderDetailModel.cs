using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ShipmentOrderDetail")]
    public class ShipmentOrderDetailModel
    {
        public string ShipmentNumber { get; set; }
        public string ShipmentStatus { get; set; }
        public string ShipmentStatusDescription { get; set; }
        public string OrderNumber { get; set; }
        public Int32? LineNumber { get; set; }
        public string ProductID { get; set; }
        public string AssemblyType { get; set; }
        public Guid GUIDShipmentOrderDetail { get; set; }
        public Guid GUIDShipmentOrder { get; set; }
        public Guid GUIDOrderDetail { get; set; }
        public Decimal? QtyScheduled { get; set; }
        public Guid GUIDOrder { get; set; }
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid GUIDShipment { get; set; }
    }
}
