using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImpExpDocumentTable")]
    public class ImpExpDocumentTableModel
    {
        public string DocumentID { get; set; } 
        public string SubdocumentID { get; set; } 
        public Int32 TableNumber { get; set; } 
        public string Table { get; set; }
        public string TableType { get; set; } 
        public string TableDescription { get; set; }
        public string XPath { get; set; }
        public Int32? ParentTableNumber { get; set; }
        public Boolean AllowInsert { get; set; }
        public Boolean AllowUpdate { get; set; }
    }
}
