using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("PODetailReceived")]
    public class PODetailReceivedModel
    {
        public Guid? GUIDPODetail { get; set; }
        public Decimal? ReceivedQuantity { get; set; }
        public Decimal? ReceivedAmount { get; set; }
        public Int64? Count { get; set; }
    }
}
