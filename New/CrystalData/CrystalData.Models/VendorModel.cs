using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("Vendor")]
    public class VendorModel
    {
        public Guid GUIDVendor { get; set; } 
        public string VendorListID { get; set; }
        public string VendorID { get; set; }
        public string Name { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipAddress3 { get; set; }
        public string ShipAddress4 { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string ShipZip { get; set; }
        public string ShipCountry { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Pager { get; set; }
        public string AltPhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string AltContact { get; set; }
        public string NameOnCheck { get; set; }
        public string Notes { get; set; }
        public string AccountNumber { get; set; }
        public Guid? GUIDVendorType { get; set; }
        public Guid? GUIDTerms { get; set; }
        public Decimal? CreditLimit { get; set; }
        public string VendorTaxIdent { get; set; }
        public Boolean IsVendorEligibleFor1099 { get; set; }
        public Decimal? Balance { get; set; }
        public string VendCustID { get; set; }
        public Boolean IsTaxOnTax { get; set; }
        public Boolean Active { get; set; }
        public Guid? GUIDCurrency { get; set; }
        public Guid? GUIDTaxCode { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string TermCode { get; set; }
        public string VendorType { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public string TaxCode { get; set; }
    }
}
