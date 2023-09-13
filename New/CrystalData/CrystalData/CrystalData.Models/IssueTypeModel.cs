using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("IssueType")]
    public class IssueTypeModel
    {
        public Guid GUIDIssueType { get; set; } 
        public string IssueType { get; set; } 
        public string Description { get; set; }
        public string IssueGroup { get; set; }
        public Boolean EditableDueDate { get; set; }
        public Boolean Active { get; set; }
    }
}
