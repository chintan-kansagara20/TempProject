using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImportDefaultSourceFields")]
    public class ImportDefaultSourceFieldsModel
    {
        public string FileType { get; set; } 
        public string DocumentID { get; set; } 
        public string SubdocumentID { get; set; } 
        public string Name { get; set; } 
        public Int32? StartPos { get; set; }
        public Int32? Length { get; set; }
        public string Match { get; set; }
        public string Select { get; set; }
        public Boolean Active { get; set; }
    }
}
