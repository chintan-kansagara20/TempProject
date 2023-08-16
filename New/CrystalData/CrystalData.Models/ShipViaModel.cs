using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ShipVia")]
    public class ShipViaModel
    {
        public Int32 PKIDShipVia { get; set; } 
        public string ShipVia { get; set; } 
        public string CarrierType { get; set; }
        public string DefaultCarrier { get; set; }
        public string DefaultCarrierService { get; set; }
        public Boolean Active { get; set; }
        public Guid? GUIDTemplate { get; set; }
    }
}
