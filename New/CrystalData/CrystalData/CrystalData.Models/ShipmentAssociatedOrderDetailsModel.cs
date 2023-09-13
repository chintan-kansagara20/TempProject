using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ShipmentAssociatedOrderDetails")]
    public class ShipmentAssociatedOrderDetailsModel
    {
        public string ShipmentNumber { get; set; }
        public string ShipmentStatus { get; set; }
        public Guid GUIDShipment { get; set; }
        public Guid? GUIDInvoice { get; set; }
        public Guid GUIDShipmentOrder { get; set; }
        public Guid GUIDOrder { get; set; }
        public Guid? GUIDOrderDetail { get; set; }
        public Guid? GUIDShipmentItem { get; set; }
        public Guid? GUIDShipmentPack { get; set; }
        public Guid? GUIDShipmentOrderDetail { get; set; }
        public Guid? GUIDInvoiceDetail { get; set; }
        public Decimal? QtyShipped { get; set; }
    }
}
