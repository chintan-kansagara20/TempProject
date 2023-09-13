using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("PicklistDetailLot")]
    public class PicklistDetailLotModel
    {
        public Guid GUIDPicklist { get; set; } 
        public Guid GUIDPicklistDetail { get; set; } 
        public Guid GUIDPicklistDetailLot { get; set; } 
        public Guid? GUIDINVLotSerial { get; set; }
        public Guid GUIDOrder { get; set; } 
        public Guid GUIDOrderDetail { get; set; } 
        public Decimal? QtyPicked { get; set; }
        public Decimal? WeightPicked { get; set; }
        public Decimal? LengthPicked { get; set; }
        public Decimal? QtyToPick { get; set; }
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string ProductID { get; set; }
        public string Description { get; set; }
        public string PicklistID { get; set; }
        public string OrderNumber { get; set; } 
        public DateTime? OrderDate { get; set; }
        public string Warehouse { get; set; }
        public string OrderID { get; set; }
        public string PriceUnit { get; set; }
        public string Unit { get; set; }
        public string LotNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Reference { get; set; }
        public string Specification { get; set; }
    }
}
