using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CostLayerReceipts")]
    public class CostLayerReceiptsModel
    {
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Int32? CostLayer { get; set; }
        public Decimal? QtyReceived { get; set; }
        public Decimal? AmtReceived { get; set; }
    }
}
