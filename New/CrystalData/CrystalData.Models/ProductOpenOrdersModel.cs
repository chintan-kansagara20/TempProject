using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductOpenOrders")]
    public class ProductOpenOrdersModel
    {
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public Guid? GUIDCustomer { get; set; }
        public Guid? GUIDVendor { get; set; }
        public string Name { get; set; }
        public Guid GUIDTransaction { get; set; } 
        public DateTime? RequestedDate { get; set; }
        public string DocumentID { get; set; }
        public string DocumentTypeID { get; set; }
        public string DocumentType { get; set; }
        public Decimal? Quantity { get; set; }
        public Decimal? Amount { get; set; }
        public Decimal? QuantityOutstanding { get; set; }
        public Decimal? Balance { get; set; }
    }
}
