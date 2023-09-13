using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvLotSerialLocationSummary")]
    public class cvLotSerialLocationSummaryModel
    {
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; } 
        public Guid? GUIDWarehouse { get; set; }
        public string Warehouse { get; set; }
        public string WarehouseDescription { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public string LotNumber { get; set; } 
        public Guid? GUIDWHLocation { get; set; }
        public string Location { get; set; }
        public string Zone { get; set; }
        public Int32? Sequence { get; set; }
        public Decimal? OnHand { get; set; }
        public Decimal? Amount { get; set; }
        public Decimal? Available { get; set; }
        public Decimal? OrderQuantity { get; set; }
        public Decimal? UnpostedComponentQuantity { get; set; }
        public Decimal? UnpostedTransferOut { get; set; }
        public DateTime? LastReceiptDate { get; set; }
        public Decimal? UnitCost { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Reference { get; set; }
        public string Specification { get; set; }
    }
}
