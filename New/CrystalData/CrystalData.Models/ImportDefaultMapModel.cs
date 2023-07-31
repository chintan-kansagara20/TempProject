using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImportDefaultMap")]
    public class ImportDefaultMapModel
    {
        public string FileType { get; set; } 
        public string DocumentID { get; set; } 
        public string SubdocumentID { get; set; } 
        public string SourceField { get; set; }
        public string Destination { get; set; } 
    }
}
