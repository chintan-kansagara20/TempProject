using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("LotSerialInventory")]
    public class LotSerialInventoryModel
    {
        public Guid GUIDProduct { get; set; } 
        public string ProductID { get; set; } 
        public Guid? GUIDWarehouse { get; set; }
        public string Warehouse { get; set; }
        public Int32? LotClosed { get; set; }
        public string LotNumber { get; set; } 
        public DateTime? TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public string PONumber { get; set; }
        public Int32? POLineNumber { get; set; }
        public string Description { get; set; }
        public Decimal? QtyReceived { get; set; }
        public Decimal? QtyIssued { get; set; }
        public Decimal? OnHand { get; set; }
        public Decimal? Available { get; set; }
        public Decimal? Transfer { get; set; }
        public string Unit { get; set; }
        public Decimal? UnitCost { get; set; }
        public Decimal? AmtReceived { get; set; }
        public Decimal? AmtIssued { get; set; }
        public Decimal? Amount { get; set; }
        public string Location { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public string Reference { get; set; }
        public string Specification { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
    }
}
