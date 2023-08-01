using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("InvoiceAmtSummary")]
    public class InvoiceAmtSummaryModel
    {
        public Guid? GUIDInvoice { get; set; }
        public Decimal? Amount { get; set; }
        public Decimal? Discount { get; set; }
        public Decimal? Retainage { get; set; }
    }
}
