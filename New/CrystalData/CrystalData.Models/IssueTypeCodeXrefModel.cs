using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("IssueTypeCodeXref")]
    public class IssueTypeCodeXrefModel
    {
        public Guid GUIDTypeCodeXref { get; set; } 
        public Guid GUIDIssueType { get; set; } 
        public Guid GUIDIssueCode { get; set; } 
        public Boolean DefaultCode { get; set; }
        public string IssueType { get; set; } 
        public string IssueCode { get; set; } 
    }
}
