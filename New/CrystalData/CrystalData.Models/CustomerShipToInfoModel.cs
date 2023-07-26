using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerShipToInfo")]
    public class CustomerShipToInfoModel
    {
        public Guid GUIDLocation { get; set; }
        public string MapReference { get; set; }
        public Decimal? Distance { get; set; }
        public string Routing { get; set; }
        public string SpecialInstructions { get; set; }
        public string ShippingInstructions { get; set; }
        public Boolean HoldShipments { get; set; }
        public DateTime? HoldFromDate { get; set; }
        public DateTime? HoldToDate { get; set; }
        public string Comment { get; set; }
        public string ShipVia { get; set; }
        public string FOB { get; set; }
        public string DefaultJobNumber { get; set; }
        public Boolean IsDistributionCenter { get; set; }
        public Guid? GUIDDistributionCenter { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDRoute { get; set; }
        public Decimal? StopNumber { get; set; }
        public string Route { get; set; }
    }
}
