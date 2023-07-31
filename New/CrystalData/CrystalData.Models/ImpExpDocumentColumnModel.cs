using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImpExpDocumentColumn")]
    public class ImpExpDocumentColumnModel
    {
        public Int32 PKIDImpExpDocumentColumn { get; set; } 
        public string DocumentID { get; set; }
        public string SubdocumentID { get; set; } 
        public string Table { get; set; }
        public string InternalName { get; set; }
        public string ExternalName { get; set; }
        public string DataType { get; set; }
        public string FieldType { get; set; }
        public string MapGUID { get; set; }
        public string DefaultValue { get; set; }
        public string Description { get; set; }
        public Int32 ValuesAreFromSql { get; set; } 
        public string Values { get; set; }
        public Int32 ConstrainValuesToList { get; set; } 
        public Int32? SortOrder { get; set; }
    }
}
