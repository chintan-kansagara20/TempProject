using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbWorkFlowStatus")]
    public class tbWorkFlowStatusModel
    {
        public string WorkFlowStatus { get; set; }
        public string Description { get; set; }
        public Int32? SortOrder { get; set; }
    }
}
