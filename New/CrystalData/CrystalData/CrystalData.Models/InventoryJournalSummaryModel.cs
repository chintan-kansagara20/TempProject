using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("InventoryJournalSummary")]
    public class InventoryJournalSummaryModel
    {
        public Int32 Synchronized { get; set; } 
        public string RefNumber { get; set; }
        public string Account { get; set; }
        public string Memo { get; set; }
        public DateTime? TransactionDate { get; set; }
        public Decimal? Amount { get; set; }
    }
}
