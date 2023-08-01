using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImportTransformation")]
    public class ImportTransformationModel
    {
        public string TemplateID { get; set; } 
        public string SetCmd { get; set; } 
        public string WhereCmd { get; set; } 
        public string Sql { get; set; }
        public Int16? Sequence { get; set; }
    }
}
