using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductCustomer")]
    public class ProductCustomerModel
    {
        public string CustomerID { get; set; } 
        public string ProductID { get; set; } 
        public Guid GUIDProductCustomer { get; set; } 
        public Guid GUIDProduct { get; set; } 
        public Guid? GUIDCustomer { get; set; }
        public string CustomerProductID { get; set; }
        public string CustomerDescription { get; set; }
        public string Note { get; set; }
    }
}
