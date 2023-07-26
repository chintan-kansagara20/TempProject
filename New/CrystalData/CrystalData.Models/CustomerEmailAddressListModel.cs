using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerEmailAddressList")]
    public class CustomerEmailAddressListModel
    {
        public string CustomerType { get; set; }
        public Guid GUIDCustomer { get; set; }
        public string CustID { get; set; }
        public Boolean? Status { get; set; }
        public string SalespersonID { get; set; }
        public string BranchID { get; set; }
        public string ContactName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Boolean? ContactStatus { get; set; }
    }
}
