using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbCustomerPaymentInvoice")]
    public class tbCustomerPaymentInvoiceModel
    {
        public Guid GUIDCustomerPaymentInvoice { get; set; }
        public Guid GUIDCustomerPayment { get; set; }
        public Guid GUIDInvoice { get; set; }
        public Decimal? PaymentAmount { get; set; }
        public Decimal? DiscountAmount { get; set; }
        public Guid? GUIDDiscountAccount { get; set; }
        public string LinkType { get; set; }
    }
}
