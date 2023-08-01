using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("InvoicesAndCharges")]
    public class InvoicesAndChargesModel
    {
        public Guid GUIDInvoice { get; set; } 
        public string InvNo { get; set; }
        public string Type { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? DueDate { get; set; }
        public Guid? GUIDCustomer { get; set; }
        public string CustPO { get; set; }
        public string SOOrderNo { get; set; }
        public string LocationID { get; set; }
        public Decimal? ForeignInvTotal { get; set; }
        public Decimal? InvTotal { get; set; }
        public Decimal? ForeignAmtPaid { get; set; }
        public Decimal? AmtPaid { get; set; }
        public Decimal? ForeignDiscAmt { get; set; }
        public Decimal? DiscAmt { get; set; }
        public Decimal? ForeignInvBal { get; set; }
        public Decimal? ForeignInvBalWithVoided { get; set; }
        public Decimal? InvBal { get; set; }
        public Int32 CreditApplied { get; set; }
        public Int32 WriteOffAmt { get; set; }
        public Int32 InDispute { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
    }
}
