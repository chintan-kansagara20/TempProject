using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("Employee")]
    public class EmployeeModel
    {
        public Guid GUIDEmployee { get; set; } 
        public string EmployeeListID { get; set; }
        public string EmployeeId { get; set; }
        public string PayrollEmployeeID { get; set; }
        public Decimal? CostRate { get; set; }
        public Decimal? BillingRate { get; set; }
        public string LaborRate { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string HomePhoneNum { get; set; }
        public string EmergPhoneNum { get; set; }
        public string EMail { get; set; }
        public string JobTitle { get; set; }
        public string DepartmentID { get; set; }
        public string LocationID { get; set; }
        public Boolean Active { get; set; }
        public Int32? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
