using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerInfo")]
    public class CustomerInfoModel
    {
        public Guid GUIDCustomer { get; set; }
        public string WebAddress { get; set; }
        public DateTime? DateOpened { get; set; }
        public DateTime? LastCreditReview { get; set; }
        public string OwnershipStyle { get; set; }
        public Decimal? AnnualSales { get; set; }
        public string CreditRating { get; set; }
        public string CreditRatingSource { get; set; }
        public string ClosingAgeHistory { get; set; }
        public string PriceCode { get; set; }
        public Decimal? TradeDiscountPct { get; set; }
        public string InvoiceText { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string DefaultReference { get; set; }
        public string DefaultReference2 { get; set; }
        public string AlternateCustomerID { get; set; }
        public Guid? GUIDBranch { get; set; }
        public string MarketingCode { get; set; }
        public Guid? GUIDPartner { get; set; }
        public Guid? GUIDReferredBy { get; set; }
        public string ReferredByType { get; set; }
        public Guid? GUIDTemplate { get; set; }
        public string WebCustomerID { get; set; }
        public Boolean IgnoreOverdueInvoices { get; set; }
        public string RedactionStatus { get; set; }
        public string BranchID { get; set; }
    }
}
