using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerPaymentView")]
    public class CustomerPaymentViewModel
    {
        public Guid GUIDCustomerPayment { get; set; }
        public Guid GUIDCustomer { get; set; }
        public string TxnID { get; set; }
        public Guid? GUIDARAccount { get; set; }
        public DateTime? TxnDate { get; set; }
        public string RefNumber { get; set; }
        public Decimal? TotalAmount { get; set; }
        public Guid? GUIDPaymentMethod { get; set; }
        public string Memo { get; set; }
        public string CCNumber { get; set; }
        public Int32? CCExpMonth { get; set; }
        public Int32? CCExpYear { get; set; }
        public string CCName { get; set; }
        public string CCAddress { get; set; }
        public string CCPostalCode { get; set; }
        public string CCTransID { get; set; }
        public string CCAuthorizationCode { get; set; }
        public string CCMerchAcctNumber { get; set; }
        public string CCReconBatchID { get; set; }
        public Int32? CCPaymentGroupingCode { get; set; }
        public DateTime? CCTxnAuthTime { get; set; }
        public Int32? CCTxnAuthStamp { get; set; }
        public Int32? CCAVSStreet { get; set; }
        public Int32? CCAVSZip { get; set; }
        public string CCStatusCode { get; set; }
        public string CCStatusMessage { get; set; }
        public DateTime? CheckDate { get; set; }
        public Decimal ExchangeRate { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public Boolean DoNotSync { get; set; }
        public Int32 PKIDCustomerPayment { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string AccountType { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountNumber { get; set; }
        public string DisplayAcctNumber { get; set; }
        public string Phone { get; set; }
        public string BankName { get; set; }
        public Guid GUIDCustomerPaymentInvoice { get; set; }
        public Guid GUIDInvoice { get; set; }
        public Decimal? PaymentAmount { get; set; }
        public Decimal? DiscountAmount { get; set; }
        public Guid? GUIDDiscountAccount { get; set; }
        public string DiscountAccount { get; set; }
    }
}
