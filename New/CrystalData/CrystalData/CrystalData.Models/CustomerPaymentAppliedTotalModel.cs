using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerPaymentAppliedTotal")]
    public class CustomerPaymentAppliedTotalModel
    {
        public Guid GUIDCustomer { get; set; }
        public Decimal? TotalAmount { get; set; }
        public Int64? Count { get; set; }
    }
}
