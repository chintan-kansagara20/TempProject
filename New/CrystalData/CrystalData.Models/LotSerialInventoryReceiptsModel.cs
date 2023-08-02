using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("LotSerialInventoryReceipts")]
    public class LotSerialInventoryReceiptsModel
    {
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string Warehouse { get; set; }
        public string LotNumber { get; set; } 
        public DateTime? TransactionDate { get; set; }
        public string TransactionType { get; set; } 
        public string PONumber { get; set; }
        public Int32? POLineNumber { get; set; }
        public Guid? GUIDPODetail { get; set; }
        public string Description { get; set; }
        public Decimal? QtyReceived { get; set; }
        public string Unit { get; set; }
        public Decimal? UnitCost { get; set; }
        public Decimal? AmtReceived { get; set; }
        public string Location { get; set; }
        public string Reference { get; set; }
        public string Specification { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid GUIDINVLotSerial { get; set; } 
    }
}
