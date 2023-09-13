using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ReportParameters")]
    public class ReportParametersModel
    {
        public string ReportID { get; set; } 
        public Int32 Sequence { get; set; } 
        public string Name { get; set; }
        public string Type { get; set; }
        public string DBField { get; set; }
        public Boolean Required { get; set; }
        public Boolean Customized { get; set; }
        public Boolean CYMAFile { get; set; }
    }
}
