using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("EDIOrdersEx")]
    public class EDIOrdersExModel
    {
        public Guid GUIDOrder { get; set; } 
        public Guid? GUIDPartner { get; set; }
        public string OriginalPONumber { get; set; }
        public DateTime? OriginalPODate { get; set; }
        public string BuyerName { get; set; }
        public string StoreLocation { get; set; }
        public DateTime? RequestedShipDate { get; set; }
        public Boolean Exported855 { get; set; }
        public DateTime? Exported855Date { get; set; }
        public Guid? GUIDTransactionSet { get; set; }
        public string DepartmentNumber { get; set; }
        public string ProductGroup { get; set; }
        public string MarkForCode { get; set; }
        public string CancelDate { get; set; }
        public string MerchandiseTypeCode { get; set; }
        public string PONumber { get; set; }
        public DateTime? PODate { get; set; }
    }
}
