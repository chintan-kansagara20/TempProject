using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("MarketingListXref")]
    public class MarketingListXrefModel
    {
        public Guid GUIDListXref { get; set; } 
        public Guid GUIDCustomer { get; set; } 
        public Guid GUIDList { get; set; } 
        public string ListCode { get; set; }
        public string Description { get; set; }
        public Boolean Active { get; set; }
        public string CustID { get; set; } 
    }
}
