using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("PODetailReceiptSummary")]
    public class PODetailReceiptSummaryModel
    {
        public Guid GUIDPODetail { get; set; } 
        public Decimal? DisplayQtyReceived { get; set; }
        public Decimal? DisplayAvgReceiptCost { get; set; }
        public Decimal? ForeignDisplayAvgReceiptCost { get; set; }
        public Decimal? AmtReceived { get; set; }
        public Decimal? ForeignAmtReceived { get; set; }
        public Int32? ReceiptCount { get; set; }
        public DateTime? FirstReceiptDate { get; set; }
        public DateTime? LastReceiptDate { get; set; }
    }
}
