using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("InventoryJournalDetail_NoAccounts")]
    public class InventoryJournalDetail_NoAccountsModel
    {
        public Guid? GUIDJournal { get; set; }
        public string RefNumber { get; set; }
        public string TxnID { get; set; }
        public Int32 Synchronized { get; set; } 
        public string Memo { get; set; }
        public Int32? RegNumber { get; set; }
        public string SessionType { get; set; }
        public string TransactionType { get; set; } 
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public Decimal? Quantity { get; set; }
        public Decimal? DebitAmount { get; set; }
        public Decimal? CreditAmount { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string WarehouseID { get; set; }
        public DateTime? TransactionDate { get; set; }
        public Guid? GUIDDebitAccount { get; set; }
        public Guid? GUIDCreditAccount { get; set; }
        public Guid? GUIDCurrentDebitAccount { get; set; }
        public Guid? GUIDCurrentCreditAccount { get; set; }
        public Guid? GUIDClass { get; set; }
        public Guid? GUIDEntity { get; set; }
        public Guid GUIDINVTransactionDetail { get; set; } 
    }
}
