using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("IssueTypeStatusXref")]
    public class IssueTypeStatusXrefModel
    {
        public Guid GUIDTypeStatusXref { get; set; } 
        public Guid GUIDIssueType { get; set; } 
        public Guid GUIDStatusCode { get; set; } 
        public Boolean DefaultCode { get; set; }
        public Int16 Sequence { get; set; } 
        public string IssueType { get; set; } 
        public string StatusCode { get; set; } 
    }
}
