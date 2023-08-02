using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("IssueTypeSchedulingClassXref")]
    public class IssueTypeSchedulingClassXrefModel
    {
        public Guid GUIDTypeSchedulingClassXref { get; set; } 
        public Guid GUIDIssueType { get; set; } 
        public Guid GUIDSchedulingClass { get; set; } 
        public Boolean DefaultCode { get; set; }
        public string IssueType { get; set; } 
        public string SchedulingClass { get; set; } 
    }
}
