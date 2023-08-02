using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("IssueTypeResolutionXref")]
    public class IssueTypeResolutionXrefModel
    {
        public Guid GUIDTypeResolutionXref { get; set; } 
        public Guid GUIDIssueType { get; set; } 
        public Guid GUIDResolutionCode { get; set; } 
        public Boolean DefaultCode { get; set; }
        public string IssueType { get; set; } 
        public string ResolutionCode { get; set; } 
    }
}
