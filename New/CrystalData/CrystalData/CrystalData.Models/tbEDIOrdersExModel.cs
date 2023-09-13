using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbEDIOrdersEx")]
    public class tbEDIOrdersExModel
    {
        public Guid GUIDOrder { get; set; }
        public Guid? GUIDPartner { get; set; }
        public string PONumber { get; set; }
        public DateTime? PODate { get; set; }
        public string BuyerName { get; set; }
        public string StoreLocation { get; set; }
        public DateTime? RequestedShipDate { get; set; }
        public Boolean Exported855 { get; set; } = true;
        public DateTime? Exported855Date { get; set; }
        public Guid? GUIDTransactionSet { get; set; }
    }
}
