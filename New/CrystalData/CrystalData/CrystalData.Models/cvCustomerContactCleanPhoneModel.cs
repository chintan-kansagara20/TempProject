using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvCustomerContactCleanPhone")]
    public class cvCustomerContactCleanPhoneModel
    {
        public string CustId { get; set; }
        public string CustomerName { get; set; }
        public string AccountNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string AccountPhone { get; set; }
        public string Email { get; set; }
        public string CleanAccountPhone { get; set; }
        public string ContactId { get; set; }
        public string ContactTitle { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string CleanContactPhone { get; set; }
        public string ContactMobile { get; set; }
        public string CleanContactMobile { get; set; }
        public Guid GUIDCustomer { get; set; }
        public string CorporateContact { get; set; }
        public string AlternativeContact { get; set; }
        public Guid? GUIDCustomerContact { get; set; }
        public string CompanyName { get; set; }
    }
}
