using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvInvoiceBalance")]
    public class cvInvoiceBalanceModel
    {
        public string InvoiceNumber { get; set; }
        public string InvoiceNumberSort { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string Type { get; set; }
        public Boolean PostedToAR { get; set; }
        public DateTime? DatePosted { get; set; }
        public Int32? TransactionPeriod { get; set; }
        public Int32? TransactionYear { get; set; }
        public string CustomerID { get; set; }
        public string LocationID { get; set; }
        public string SalespersonID { get; set; }
        public string BranchID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string BillToName { get; set; }
        public string BillToAddress1 { get; set; }
        public string BillToCity { get; set; }
        public string BillToState { get; set; }
        public string BillToZip { get; set; }
        public Decimal? SubTotal { get; set; }
        public Decimal? InvoiceDiscountPct { get; set; }
        public Decimal? InvoiceDiscountAmount { get; set; }
        public Decimal? SalesTax { get; set; }
        public Decimal? ShippingCharge { get; set; }
        public Decimal? TotalAmount { get; set; }
        public string Reference { get; set; }
        public string TermsCode { get; set; }
        public DateTime? DueDate { get; set; }
        public string ContractID { get; set; }
        public Decimal? PaymentAmountReceived { get; set; }
        public Decimal? PaymentDiscountAmount { get; set; }
    }
}
