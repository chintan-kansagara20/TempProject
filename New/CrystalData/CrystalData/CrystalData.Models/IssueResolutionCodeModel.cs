using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("IssueResolutionCode")]
    public class IssueResolutionCodeModel
    {
        public Guid GUIDResolutionCode { get; set; } 
        public string ResolutionCode { get; set; } 
        public string Description { get; set; }
        public Boolean Active { get; set; }
    }
}
