using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("LotSerialInventoryIssues")]
    public class LotSerialInventoryIssuesModel
    {
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string Warehouse { get; set; }
        public string LotNumber { get; set; }
        public Decimal? QtyIssued { get; set; }
        public Decimal? AmtIssued { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
    }
}
