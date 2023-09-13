using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("PODetailInvoiced")]
    public class PODetailInvoicedModel
    {
        public Guid? GUIDPODetail { get; set; }
        public Decimal? InvoicedQuantity { get; set; }
        public Decimal? InvoicedAmount { get; set; }
        public Int64? Count { get; set; }
    }
}
