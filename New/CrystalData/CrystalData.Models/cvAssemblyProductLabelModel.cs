using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyProductLabel")]
    public class cvAssemblyProductLabelModel
    {
        public string LotNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string LabelIngredients { get; set; } 
        public string _allergens { get; set; }
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public Decimal? Quantity { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public Decimal? InnerPackQty { get; set; }
        public string _StorageConditions { get; set; }
        public string _LotLabelType { get; set; }
        public string Size { get; set; }
        public string UPC { get; set; }
        public string AltDescription { get; set; }
        public string CustId { get; set; }
        public string CompanyName { get; set; }
        public string CustomerContact { get; set; } 
        public Guid? GUIDINVLotSerial { get; set; }
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDOrderDetail { get; set; }
    }
}
