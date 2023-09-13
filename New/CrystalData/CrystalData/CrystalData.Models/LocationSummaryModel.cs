using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("LocationSummary")]
    public class LocationSummaryModel
    {
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; } 
        public Guid? GUIDWarehouse { get; set; }
        public string Warehouse { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public string Location { get; set; }
        public Boolean? PrimaryLocation { get; set; }
        public string Zone { get; set; }
        public Int32? Sequence { get; set; }
        public Decimal? OnHand { get; set; }
        public Decimal? Available { get; set; }
        public Decimal? Transfer { get; set; }
        public DateTime? LastReceiptDate { get; set; }
    }
}
