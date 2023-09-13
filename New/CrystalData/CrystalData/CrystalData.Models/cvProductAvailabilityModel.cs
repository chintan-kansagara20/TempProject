using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductAvailability")]
    public class cvProductAvailabilityModel
    {
        public string ProductID { get; set; } 
        public string ProductDescription { get; set; }
        public Decimal? OnHand { get; set; }
        public Decimal? Available { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string WarehouseID { get; set; }
        public string Location { get; set; }
        public string LotNumber { get; set; }
        public Guid? GUIDLotSerial { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
