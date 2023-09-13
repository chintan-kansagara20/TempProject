using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("InventoryJournal")]
    public class InventoryJournalModel
    {
        public Int32 Synchronized { get; set; } 
        public string Account { get; set; }
        public string RefNumber { get; set; }
        public string Memo { get; set; }
        public Int32? SessionNumber { get; set; }
        public string SessionType { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string ProductID { get; set; }
        public Decimal? Quantity { get; set; }
        public string WarehouseID { get; set; }
        public Decimal? Amount { get; set; }
    }
}
