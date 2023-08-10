using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductClass")]
    public class ProductClassModel
    {
        public Guid GUIDProductClass { get; set; } 
        public string ItemListID { get; set; }
        public string ProductClassID { get; set; }
        public string Description { get; set; }
        public Guid? GUIDSalesAccount { get; set; }
        public Guid? GUIDReturnsAccount { get; set; }
        public Guid? GUIDTradeDiscountAccount { get; set; }
        public Guid? GUIDCGSAccount { get; set; }
        public Boolean Active { get; set; }
        public Guid? GUIDCGSAdjAccount { get; set; }
        public Guid? GUIDClass { get; set; }
        public string SalesAccountID { get; set; }
        public string ReturnsAccountID { get; set; }
        public string TradeDiscountAccountID { get; set; }
        public string CGSAccountID { get; set; }
        public string CGSAdjAccountID { get; set; }
    }
}
