using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductPrice")]
    public class ProductPriceModel
    {
        public Guid? GUIDCustomer { get; set; }
        public string ContractID { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string ProductPriceCategory { get; set; }
        public string PriceCode { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Decimal? LowQty { get; set; }
        public Decimal? HighQty { get; set; }
        public string PriceType { get; set; }
        public Decimal? Price { get; set; }
        public string PriceUnit { get; set; }
        public Boolean TaxIncluded { get; set; }
        public Boolean Discountable { get; set; }
        public string Note { get; set; }
        public Guid GUIDProductPrice { get; set; } 
        public Guid? GUIDCurrency { get; set; }
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public string ProductID { get; set; }
    }
}
