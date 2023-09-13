using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImportDefaultTable")]
    public class ImportDefaultTableModel
    {
        public string FileType { get; set; } 
        public string DocumentID { get; set; } 
        public string SubdocumentID { get; set; } 
        public string TableName { get; set; } 
        public string XPath { get; set; }
    }
}
