using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductKitSummary")]
    public class ProductKitSummaryModel
    {
        public Guid GUIDProduct { get; set; } 
        public string ProductID { get; set; } 
        public string Description { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Decimal? Available { get; set; }
        public DateTime? LastTransactionDate { get; set; }
        public DateTime? LastVoidedDate { get; set; }
        public DateTime? LastINVUpdatedDate { get; set; }
    }
}
