using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("INVTransactionDetailSummary")]
    public class INVTransactionDetailSummaryModel
    {
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string Warehouse { get; set; }
        public Decimal? QtyOnHand { get; set; }
        public Decimal? OnHandValue { get; set; }
        public DateTime? LastTransactionDate { get; set; }
    }
}
