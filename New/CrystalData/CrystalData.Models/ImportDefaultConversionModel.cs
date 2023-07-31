using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImportDefaultConversion")]
    public class ImportDefaultConversionModel
    {
        public string FileType { get; set; }
        public string DocumentID { get; set; }
        public string SubdocumentID { get; set; }
        public string Destination { get; set; }
        public string FromValue { get; set; }
        public string ToValue { get; set; }
    }
}
