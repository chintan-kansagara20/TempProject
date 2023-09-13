using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ShipmentOrderDetailToPack")]
    public class ShipmentOrderDetailToPackModel
    {
        public string OrderNumber { get; set; } 
        public string OrderStatus { get; set; }
        public string LineType { get; set; }
        public Int32? LineNumber { get; set; }
        public Int32 SubLineNumber { get; set; } 
        public Int32 ComponentLevel { get; set; } 
        public string ProductID { get; set; }
        public string WarehouseID { get; set; }
        public string AssemblyType { get; set; }
        public Decimal? QtyScheduled { get; set; }
        public Decimal? QtyToPack { get; set; }
        public Decimal? QtyPickedNotPacked { get; set; }
        public Guid? GUIDOrder { get; set; }
        public Guid GUIDOrderDetail { get; set; } 
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDPicklist { get; set; }
        public Guid? GUIDPicklistDetail { get; set; }
    }
}
