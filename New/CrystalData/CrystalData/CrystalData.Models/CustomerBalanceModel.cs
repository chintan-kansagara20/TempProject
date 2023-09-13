using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerBalance")]
    public class CustomerBalanceModel
    {
        public Guid GUIDCustomer { get; set; }
        public Decimal? BalDue { get; set; }
    }
}
