using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("PO")]
    public class POModel
    {
        public Guid? GUIDAPAccount { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedByID { get; set; }
        public DateTime? ApprovedInvoiceDate { get; set; }
        public Decimal? ApprovedInvoiceDiscountAmount { get; set; }
        public Decimal? ForeignApprovedInvoiceDiscountAmount { get; set; }
        public DateTime? ApprovedInvoiceDiscountDate { get; set; }
        public DateTime? ApprovedInvoiceDueDate { get; set; }
        public string ApprovedInvoiceNumber { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateCompleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateIssued { get; set; }
        public DateTime? DatePrinted { get; set; }
        public DateTime? DateRequested { get; set; }
        public DateTime? DontShipAfter { get; set; }
        public DateTime? DontShipBefore { get; set; }
        public string EnteredBy { get; set; }
        public string FOB { get; set; }
        public string IssuedBy { get; set; }
        public string Notes { get; set; }
        public string PONumber { get; set; }
        public string PONumberSort { get; set; }
        public string POStatus { get; set; }
        public Boolean Printed { get; set; }
        public DateTime? PromisedDate { get; set; }
        public Guid? GUIDPurchaseAccount { get; set; }
        public Boolean ReadyToPrint { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestedBy { get; set; }
        public string RequestedByID { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToAddress3 { get; set; }
        public string ShipToAddress4 { get; set; }
        public string ShipToAttention { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToCountry { get; set; }
        public string ShipToName { get; set; }
        public Boolean ShipToOverride { get; set; }
        public string ShipToState { get; set; }
        public string ShipToZip { get; set; }
        public string ShipVia { get; set; }
        public string SpecialInstructions { get; set; }
        public string StatusChangedBy { get; set; }
        public DateTime? StatusDate { get; set; }
        public Decimal? SubTotalAmountApproved { get; set; }
        public Decimal? ForeignSubTotalAmountApproved { get; set; }
        public string SupplierName { get; set; }
        public string SupplierBillAddress1 { get; set; }
        public string SupplierBillAddress2 { get; set; }
        public string SupplierBillAddress3 { get; set; }
        public string SupplierBillAddress4 { get; set; }
        public string SupplierBillCity { get; set; }
        public string SupplierBillState { get; set; }
        public string SupplierBillZip { get; set; }
        public string SupplierBillCountry { get; set; }
        public Boolean SupplierOverride { get; set; }
        public string SupplierAddress1 { get; set; }
        public string SupplierAddress2 { get; set; }
        public string SupplierAddress3 { get; set; }
        public string SupplierAddress4 { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierState { get; set; }
        public string SupplierZip { get; set; }
        public string SupplierCountry { get; set; }
        public Boolean? TaxExempt { get; set; }
        public Guid? GUIDTerms { get; set; }
        public Decimal? TotalAmount { get; set; }
        public Decimal? ForeignTotalAmount { get; set; }
        public Decimal? TotalAmountApproved { get; set; }
        public Decimal? ForeignTotalAmountApproved { get; set; }
        public Decimal? TotalAmountInvoiced { get; set; }
        public Decimal? ForeignTotalAmountInvoiced { get; set; }
        public Decimal? TotalAmountOutstanding { get; set; }
        public Decimal? ForeignTotalAmountOutstanding { get; set; }
        public Decimal? TotalAmountReceived { get; set; }
        public Decimal? ForeignTotalAmountReceived { get; set; }
        public Decimal? TotalOtherAmount { get; set; }
        public Decimal? ForeignTotalOtherAmount { get; set; }
        public string Type { get; set; }
        public Guid? GUIDVendorType { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string Reference { get; set; }
        public string RelatedDocument { get; set; }
        public string VendCustID { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string FAX { get; set; }
        public string Email { get; set; }
        public Guid? GUIDVendor { get; set; }
        public Guid? GUIDOrder { get; set; }
        public Guid GUIDPO { get; set; }
        public Decimal? SalesTax { get; set; }
        public Decimal? ForeignSalesTax { get; set; }
        public Decimal? SalesTaxAmountApproved { get; set; }
        public Decimal? ForeignSalesTaxAmountApproved { get; set; }
        public Guid? GUIDTaxCode { get; set; }
        public Decimal ExchangeRate { get; set; } 
        public Boolean TaxIncluded { get; set; }
        public string VendorID { get; set; }
        public string SalesOrderNumber { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierBillAddress { get; set; }
        public string ShipToAddress { get; set; }
        public string Terms { get; set; }
        public string VendorType { get; set; }
        public string APAccountID { get; set; }
        public string PurchaseAccountID { get; set; }
        public string Warehouse { get; set; }
        public string POStatusDescription { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public string CompanyTaxID { get; set; }
    }
}
