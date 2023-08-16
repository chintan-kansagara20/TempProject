using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("SalespersonInfo")]
    public class SalespersonInfoModel
    {
        public Guid GUIDSalesperson { get; set; }
        public string SalespersonListID { get; set; }
        public string SalespersonID { get; set; }
        public string Name { get; set; }
        public string LinkType { get; set; }
        public Guid? GUIDLink { get; set; }
        public Guid? GUIDSalesAccount { get; set; }
        public Guid? GUIDReturnsAccount { get; set; }
        public Guid? GUIDTradeDiscount { get; set; }
        public Guid? GUIDCOGSAccount { get; set; }
        public Guid? GUIDClass { get; set; }
        public Boolean Status { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string ItemListID { get; set; }
        public string SalesAccountSegment { get; set; }
        public string ReturnsAccountSegment { get; set; }
        public string TradeDiscountSegment { get; set; }
        public string COGSAccountSegment { get; set; }
    }
}
