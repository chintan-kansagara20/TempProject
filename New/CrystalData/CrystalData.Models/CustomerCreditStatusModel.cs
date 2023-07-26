using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerCreditStatus")]
    public class CustomerCreditStatusModel
    {
        public Guid GUIDCustomer { get; set; }
        public string CreditStatus { get; set; }
    }
}
