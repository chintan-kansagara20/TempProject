using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbCustomerMarketingListXref")]
    public class tbCustomerMarketingListXrefModel
    {
        public Guid GUIDListXref { get; set; }
        public Guid GUIDCustomer { get; set; }
        public Guid GUIDList { get; set; }
    }
}
