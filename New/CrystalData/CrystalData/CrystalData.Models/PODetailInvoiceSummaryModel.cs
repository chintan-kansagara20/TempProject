using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("PODetailInvoiceSummary")]
    public class PODetailInvoiceSummaryModel
    {
        public Guid GUIDPODetail { get; set; } 
        public Decimal? DisplayQtyInvoiced { get; set; }
        public Decimal? DisplayAvgInvoicePrice { get; set; }
        public Decimal? AmtInvoiced { get; set; }
        public Decimal? DisplayForeignAvgInvoicePrice { get; set; }
        public Decimal? ForeignAmtInvoiced { get; set; }
        public Int32? InvoiceCount { get; set; }
        public DateTime? FirstInvoiceDate { get; set; }
        public DateTime? LastInvoiceDate { get; set; }
    }
}
