using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerPaymentInvoice")]
    public class CustomerPaymentInvoiceModel
    {
        public Guid GUIDCustomerPaymentInvoice { get; set; }
        public Guid GUIDCustomerPayment { get; set; }
        public Guid GUIDInvoice { get; set; }
        public Decimal? ForeignPaymentAmount { get; set; }
        public Decimal? PaymentAmount { get; set; }
        public Decimal? ForeignDiscountAmount { get; set; }
        public Decimal? DiscountAmount { get; set; }
        public Guid? GUIDDiscountAccount { get; set; }
        public string LinkType { get; set; }
        public string TxnID { get; set; }
        public Guid? GUIDCustomer { get; set; }
        public string DisplayAcctNumber { get; set; }
        public string CustomerID { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? TxnDate { get; set; }
        public string PaymentMethod { get; set; }
        public Int32? IsCreditCard { get; set; }
        public string RefNumber { get; set; }
        public string Memo { get; set; }
        public string DiscountAccount { get; set; }
    }
}
