using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerExport")]
    public class CustomerExportModel
    {
        public Guid GUIDCustomer { get; set; } 
        public string CustId { get; set; } 
        public Int32? Method { get; set; }
        public string CustomerType { get; set; }
        public string CompanyName { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string BillToAddress { get; set; }
        public string BillToAddress2 { get; set; }
        public string BillToAddress3 { get; set; }
        public string BillToAddress4 { get; set; }
        public string BillToCity { get; set; }
        public string BillToState { get; set; }
        public string BillToZip { get; set; }
        public string BillToCountry { get; set; }
        public string BillToPhone { get; set; }
        public string BillToPhoneDesc { get; set; }
        public string BillToFax { get; set; }
        public string BillToFaxDesc { get; set; }
        public string BillToEmail { get; set; }
        public string BillToEmailDesc { get; set; }
        public string BillToAltPhone { get; set; }
        public string BillToAltPhoneDesc { get; set; }
        public string BillToMobile { get; set; }
        public string BillToMobileDesc { get; set; }
        public string BillToPager { get; set; }
        public string BillToPagerDesc { get; set; }
        public string ARAcntId { get; set; }
        public string SalespersonID { get; set; }
        public string TaxCode { get; set; }
        public string TermsCode { get; set; }
        public Decimal? CreditLimit { get; set; }
        public Boolean CreditHold { get; set; }
        public Decimal? BalDue { get; set; }
        public Boolean? Status { get; set; }
        public string BillToComment { get; set; }
        public Boolean BillToPopupNotes { get; set; }
        public Guid? GUIDLocation { get; set; }
        public string LocationID { get; set; }
        public string LocationName { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToAddress3 { get; set; }
        public string ShipToAddress4 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToZip { get; set; }
        public string ShipToCountry { get; set; }
        public string ShipToAttn { get; set; }
        public string ShipToPhone { get; set; }
        public string ShipToPhoneDesc { get; set; }
        public string ShipToFax { get; set; }
        public string ShipToFaxCesc { get; set; }
        public string ShipToEmail { get; set; }
        public string ShipToEmailDesc { get; set; }
        public string ShipToAltPhone { get; set; }
        public string ShipToAltPhoneDesc { get; set; }
        public string ShipToMobile { get; set; }
        public string ShipToMobileDesc { get; set; }
        public string ShipToPager { get; set; }
        public string ShipToPagerDesc { get; set; }
        public Boolean? ShipToStatus { get; set; }
        public Boolean? ShipToDefault { get; set; }
        public string ShipToComment { get; set; }
        public Boolean? ShipToPopupNotes { get; set; }
    }
}
