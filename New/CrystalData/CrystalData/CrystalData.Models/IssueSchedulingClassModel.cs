using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("IssueSchedulingClass")]
    public class IssueSchedulingClassModel
    {
        public Guid GUIDSchedulingClass { get; set; } 
        public string SchedulingClass { get; set; } 
        public string Description { get; set; }
        public Boolean Active { get; set; }
    }
}
