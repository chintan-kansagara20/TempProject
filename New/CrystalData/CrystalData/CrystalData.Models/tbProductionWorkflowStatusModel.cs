using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbProductionWorkflowStatus")]
    public class tbProductionWorkflowStatusModel
    {
        public Guid GUIDProductionWorkflowStatus { get; set; }
        public string ProductionWorkFlowStatus { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public Int32? Sequence { get; set; }
    }
}
