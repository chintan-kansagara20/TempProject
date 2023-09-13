using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("INVLotSerialTrace")]
    public class INVLotSerialTraceModel
    {
        public Guid GUIDINVLotSerialTrace { get; set; } 
        public string TraceNumber { get; set; } 
        public DateTime? DocumentDate { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public string LotNumber { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public string Description { get; set; }
        public string InventoryControlType { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string WarehouseID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Boolean Track { get; set; }
        public Boolean Trace { get; set; }
        public string Document { get; set; }
        public string Reference { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
