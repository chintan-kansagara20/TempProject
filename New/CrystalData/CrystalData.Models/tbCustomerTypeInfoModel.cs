using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbCustomerTypeInfo")]
    public class tbCustomerTypeInfoModel
    {
        public Guid GUIDCustomerType { get; set; } 
        public string CustomerTypeListID { get; set; }
        public string CustomerType { get; set; } 
        public Guid? GUIDSalesAccount { get; set; }
        public Guid? GUIDReturnsAccount { get; set; }
        public Guid? GUIDTradeDiscount { get; set; }
        public Guid? GUIDCOGSAccount { get; set; }
        public Guid? GUIDClass { get; set; }
        public Boolean Active { get; set; } = true;
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public Boolean SalesOrderAlert { get; set; } = true;
        public Boolean BusinessActivityAlert { get; set; } = true;
        public string TaxExemptEntityUseCode { get; set; }
        public string ItemListID { get; set; }
    }
}
