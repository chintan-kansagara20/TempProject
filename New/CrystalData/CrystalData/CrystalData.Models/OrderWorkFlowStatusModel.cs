using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("OrderWorkFlowStatus")]
    public class OrderWorkFlowStatusModel
    {
        public Guid GUIDOrderWorkFlowStatus { get; set; } 
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public string WorkFlowStatus { get; set; }
    }
}
