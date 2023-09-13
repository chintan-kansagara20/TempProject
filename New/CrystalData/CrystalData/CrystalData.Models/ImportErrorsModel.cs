using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImportErrors")]
    public class ImportErrorsModel
    {
        public Int32 PKIDImportErrors { get; set; } 
        public Guid? GUIDImportSession { get; set; }
        public string TemplateID { get; set; }
        public Int32? RowNumber { get; set; }
        public string SourceField { get; set; }
        public string FieldValue { get; set; }
        public string Error { get; set; }
    }
}
