using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerContact")]
    public class CustomerContactModel
    {
        public Guid GUIDCustomerContact { get; set; }
        public Guid GUIDCustomer { get; set; }
        public string ContactId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
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
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
