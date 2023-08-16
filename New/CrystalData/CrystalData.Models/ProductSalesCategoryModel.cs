using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductSalesCategory")]
    public class ProductSalesCategoryModel
    {
        public Boolean Active { get; set; }
        public string Description { get; set; }
        public string SalesCategory { get; set; } 
        public Guid? GUIDSalesAccount { get; set; }
        public Guid? GUIDReturnsAccount { get; set; }
        public Guid? GUIDTradeDiscount { get; set; }
        public Guid? GUIDCOGSAccount { get; set; }
        public Guid? GUIDClass { get; set; }
        public string ItemListID { get; set; }
        public string SalesAccountSegment { get; set; }
        public string ReturnsAccountSegment { get; set; }
        public string TradeDiscountSegment { get; set; }
        public string COGSAccountSegment { get; set; }
    }
}
