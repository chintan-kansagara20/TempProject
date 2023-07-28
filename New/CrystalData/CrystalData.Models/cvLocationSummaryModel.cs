using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvLocationSummary")]
    public class cvLocationSummaryModel
    {
        public string ProductID { get; set; } 
        public Decimal? OnHand { get; set; }
        public Decimal? Available { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public string Zone { get; set; }
        public string LotNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid GUIDProduct { get; set; } 
        public Guid? GUIDInvLotSerial { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDWHLocation { get; set; }
    }
}
