using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ShipmentPicklist")]
    public class ShipmentPicklistModel
    {
        public string ShipmentNumber { get; set; }
        public string ShipmentStatus { get; set; } 
        public string PicklistID { get; set; }
        public string PicklistStatus { get; set; }
        public string ShipmentNumberSort { get; set; }
        public string PicklistIDSort { get; set; }
        public Guid GUIDShipmentPicklist { get; set; } 
        public Guid GUIDShipment { get; set; } 
        public Guid GUIDPicklist { get; set; } 
    }
}
