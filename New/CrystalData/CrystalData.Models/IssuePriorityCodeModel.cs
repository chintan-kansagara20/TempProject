using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("IssuePriorityCode")]
    public class IssuePriorityCodeModel
    {
        public Guid GUIDPriorityCode { get; set; } 
        public string PriorityCode { get; set; } 
        public string Description { get; set; }
        public Int32? HoursTillDue { get; set; }
        public Int32? Icon { get; set; }
        public Boolean Active { get; set; }
    }
}
