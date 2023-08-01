using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImportMap")]
    public class ImportMapModel
    {
        public string TemplateID { get; set; } 
        public string SubdocumentID { get; set; } 
        public Int32? Source { get; set; }
        public string SourceField { get; set; }
        public string Destination { get; set; } 
        public Int32 Override { get; set; } 
    }
}
