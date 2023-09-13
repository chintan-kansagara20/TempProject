using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("INVLotSerialTraceDetail")]
    public class INVLotSerialTraceDetailModel
    {
        public Guid GUIDINVLotSerialTraceDetail { get; set; } 
        public Guid GUIDINVLotSerialTrace { get; set; } 
        public Int32 LineNumber { get; set; } 
        public string RecordType { get; set; }
        public Guid GUIDRecord { get; set; } 
        public string Note { get; set; }
        public string LineType { get; set; }
        public string DocType { get; set; }
        public string DocID { get; set; }
        public DateTime? DocDate { get; set; }
        public Int32? DocLineNumber { get; set; }
        public Decimal? Qty { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string WarehouseID { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public string Location { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public string LotNumber { get; set; }
    }
}
