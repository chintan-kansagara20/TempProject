using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("IssueTypePriorityXref")]
    public class IssueTypePriorityXrefModel
    {
        public Guid GUIDTypePriorityXref { get; set; } 
        public Guid GUIDIssueType { get; set; } 
        public Guid GUIDPriorityCode { get; set; } 
        public Boolean DefaultCode { get; set; }
        public string IssueType { get; set; } 
        public string PriorityCode { get; set; } 
    }
}
