using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerFullName")]
    public class CustomerFullNameModel
    {
        public Guid? GUIDCustomer { get; set; }
        public string FullName { get; set; }
    }
}
