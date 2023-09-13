using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("JournalLine")]
    public class JournalLineModel
    {
        public Guid? GUIDJournal { get; set; }
        public string RefNumber { get; set; }
        public Guid? GUIDEntity { get; set; }
        public string TransactionType { get; set; } 
        public string Memo { get; set; }
        public Guid? GUIDAccount { get; set; }
        public string Account { get; set; }
        public Decimal? Amount { get; set; }
        public Guid? GUIDClass { get; set; }
    }
}
