using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerTypeInfo")]
    public class CustomerTypeInfoModel
    {
        public Guid GUIDCustomerType { get; set; } 
        public string CustomerTypeListID { get; set; }
        public string CustomerType { get; set; }
        public Guid? GUIDSalesAccount { get; set; }
        public Guid? GUIDReturnsAccount { get; set; }
        public Guid? GUIDTradeDiscount { get; set; }
        public Guid? GUIDCOGSAccount { get; set; }
        public Guid? GUIDClass { get; set; }
        public Boolean Active { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public Boolean SalesOrderAlert { get; set; }
        public Boolean BusinessActivityAlert { get; set; }
        public string TaxExemptEntityUseCode { get; set; }
        public string ItemListID { get; set; }
        public string SalesAccountSegment { get; set; }
        public string ReturnsAccountSegment { get; set; }
        public string TradeDiscountSegment { get; set; }
        public string COGSAccountSegment { get; set; }
    }
}
