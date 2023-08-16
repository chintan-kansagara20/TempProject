using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ShipmentOrderSummary")]
    public class ShipmentOrderSummaryModel
    {
        public string ShipmentNumber { get; set; }
        public string OrderNumber { get; set; }
        public Guid GUIDShipmentOrder { get; set; }
        public Guid GUIDShipment { get; set; }
        public Guid GUIDOrder { get; set; }
        public Int32? NumberOfCartons { get; set; }
        public Decimal? TotalPackageWeight { get; set; }
    }
}
