using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbEDIImportStatus")]
    public class tbEDIImportStatusModel
    {
        public Int32 PKIDEDIImportStatus { get; set; } 
        public string ImportFile { get; set; }
        public Boolean Imported { get; set; } = true;
        public string DocType { get; set; }
    }
}
