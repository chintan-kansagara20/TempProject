using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerShipView")]
    public class CustomerShipViewModel
    {
        public Guid GUIDLocation { get; set; }
        public string LocationID { get; set; }
        public Guid GUIDCustomer { get; set; }
        public string LocationName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Attn { get; set; }
        public Guid? GUIDTaxCategory { get; set; }
        public Guid? GUIDTaxCode { get; set; }
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
        public Boolean? Status { get; set; }
        public Boolean Default { get; set; }
        public string Comment { get; set; }
        public Boolean PopupNotes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string TaxCatID { get; set; }
        public string TaxCatDescription { get; set; }
        public string CustID { get; set; }
        public Guid? GUIDRoute { get; set; }
        public string Route { get; set; }
        public Decimal? StopNumber { get; set; }
    }
}
