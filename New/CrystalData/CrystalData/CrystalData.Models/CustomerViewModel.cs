using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerView")]
    public class CustomerViewModel
    {
        public Guid GUIDCustomer { get; set; } 
        public string CustListID { get; set; }
        public string CustId { get; set; } 
        public Guid? GUIDParent { get; set; }
        public Int32? Method { get; set; }
        public Guid? GUIDCustomerType { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string PhoneDesc { get; set; }
        public string Fax { get; set; }
        public string FaxDesc { get; set; }
        public string Email { get; set; }
        public string EmailDesc { get; set; }
        public string AltPhone { get; set; }
        public string AltPhoneDesc { get; set; }
        public string Mobile { get; set; }
        public string MobileDesc { get; set; }
        public string Pager { get; set; }
        public string PagerDesc { get; set; }
        public Guid? GUIDSalesperson { get; set; }
        public Guid? GUIDTaxCode { get; set; }
        public string StateSalesTaxId { get; set; }
        public Boolean TaxIncluded { get; set; }
        public Guid? GUIDTerms { get; set; }
        public string LocationId { get; set; }
        public Decimal? CreditLimit { get; set; }
        public Boolean CreditHold { get; set; }
        public Guid? PreferredPaymentMethod { get; set; }
        public Boolean? Status { get; set; }
        public string CCNumber { get; set; }
        public string CCDisplayNumber { get; set; }
        public Int32? CCExpMonth { get; set; }
        public Int32? CCExpYear { get; set; }
        public string CCName { get; set; }
        public string CCAddress { get; set; }
        public string CCPostalCode { get; set; }
        public string AccountNumber { get; set; }
        public string Comment { get; set; }
        public Boolean PopupNotes { get; set; }
        public Guid? GUIDCurrency { get; set; }
        public Guid? SyncAsGUIDCustomer { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Boolean _NoPriceOnShipmentPackList { get; set; }
        public Boolean _MarketingEmailOptIn { get; set; }
        public string _EmailSignupCampaign { get; set; }
        public Boolean _EmailOptOut { get; set; }
        public DateTime? _OptOutDate { get; set; }
        public string _OptOutReason { get; set; }
        public string _Language { get; set; }
        public Int32? TaxExemptionReasonID { get; set; }
        public string CustomerTaxID { get; set; }
        public string FullName { get; set; }
        public string FullAddress { get; set; }
        public string ARAcntId { get; set; }
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
        public string MarketingCode { get; set; }
        public Boolean? IgnoreOverdueInvoices { get; set; }
        public string BranchID { get; set; }
        public string BranchName { get; set; }
        public string CustomerType { get; set; }
        public string SalespersonID { get; set; }
        public string SalespersonName { get; set; }
        public string ReferredBy { get; set; }
        public string TaxCodeName { get; set; }
        public string TaxCodeDescription { get; set; }
        public Boolean? Taxable { get; set; }
        public string TaxExemptionReasonDesc { get; set; }
        public string TermsCode { get; set; }
        public string TermsDescription { get; set; }
        public Int32? OrderCount { get; set; }
        public DateTime? LastSalesOrderDate { get; set; }
        public Int32? AvgCollectionDays { get; set; }
        public Decimal? BalDue { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public string TemplateID { get; set; }
        public Guid? GUIDTemplate { get; set; }
        public string WebCustomerID { get; set; }
        public string SyncAsCustomerID { get; set; }
        public DateTime? FirstInvoiceDate { get; set; }
    }
}
