using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("IssueLog")]
    public class IssueLogModel
    {
        public Guid GUIDEventLog { get; set; } 
        public Guid? GUIDIssue { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? DateTime { get; set; }
        public string DataChanged { get; set; }
        public string ChangedFrom { get; set; }
        public string ChangedTo { get; set; }
        public string Employee { get; set; }
        public Guid? GUIDStatusCode { get; set; }
        public string Note { get; set; }
        public string StatusCode { get; set; }
    }
}
