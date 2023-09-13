using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("Journal")]
    public class JournalModel
    {
        public string RefNumberSort { get; set; }
        public Guid GUIDJournal { get; set; } 
        public string TxnID { get; set; }
        public DateTime? TxnDate { get; set; }
        public string RefNumber { get; set; }
        public string Memo { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public Boolean DoNotSync { get; set; }
    }
}
