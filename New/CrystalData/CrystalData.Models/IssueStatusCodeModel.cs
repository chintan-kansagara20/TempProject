using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("IssueStatusCode")]
    public class IssueStatusCodeModel
    {
        public Guid GUIDStatusCode { get; set; } 
        public string StatusCode { get; set; } 
        public string Description { get; set; }
        public Boolean SetToClosed { get; set; }
        public Int32? Icon { get; set; }
        public Boolean OnToolbar { get; set; }
        public Boolean SendMessage { get; set; }
        public Boolean Active { get; set; }
    }
}
