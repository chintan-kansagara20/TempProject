using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("POOnOrder")]
    public class POOnOrderModel
    {
        public Guid? GUIDProduct { get; set; }
        public string Warehouse { get; set; }
        public Decimal? QuantityOnOrder { get; set; }
        public Decimal? QuantityOnReturn { get; set; }
        public Decimal? QuantityInvoiceApproved { get; set; }
        public Decimal? QuantityInvoiced { get; set; }
        public Decimal? QuantityOrdered { get; set; }
        public Decimal? QuantityReceived { get; set; }
        public Decimal? AmountApproved { get; set; }
        public Decimal? AmountOnOrder { get; set; }
        public Decimal? AmountReceived { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
    }
}
