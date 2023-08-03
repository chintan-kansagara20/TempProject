using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("POInvoice")]
    public class POInvoiceModel
    {
        public Decimal? Amount { get; set; }
        public Decimal? ForeignAmount { get; set; }
        public Guid? GUIDAPAccount { get; set; }
        public DateTime? DatePostedToAP { get; set; }
        public Decimal? DiscountAmount { get; set; }
        public Decimal? ForeignDiscountAmount { get; set; }
        public DateTime? DiscountDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string FOB { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string PONumber { get; set; }
        public Boolean PostedToAP { get; set; }
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
        public string SupplierAddress1 { get; set; }
        public string SupplierAddress2 { get; set; }
        public string SupplierAddress3 { get; set; }
        public string SupplierAddress4 { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierCountry { get; set; }
        public string SupplierName { get; set; }
        public Boolean SupplierOverride { get; set; }
        public string SupplierState { get; set; }
        public string SupplierZip { get; set; }
        public Boolean? TaxExempt { get; set; }
        public Guid? GUIDTerms { get; set; }
        public Guid? GUIDVendorType { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public DateTime? TransactionDate { get; set; }
        public Guid? GUIDVendor { get; set; }
        public Guid GUIDPOInvoice { get; set; }
        public string TxnID { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public Guid? GUIDPO { get; set; }
        public string VendorID { get; set; }
        public Decimal? Balance { get; set; }
        public Boolean FromQB { get; set; }
        public Boolean DoNotSync { get; set; }
        public Decimal? SalesTax { get; set; }
        public Guid? GUIDTaxCode { get; set; }
        public Boolean TaxIncluded { get; set; }
        public Decimal ExchangeRate { get; set; } 
        public string SupplierAddress { get; set; }
        public string ShipToAddress { get; set; }
        public string Type { get; set; }
        public string VendorType { get; set; }
        public string Terms { get; set; }
        public string APAccountID { get; set; }
        public string Warehouse { get; set; }
        public string WarehouseDesc { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
    }
}
