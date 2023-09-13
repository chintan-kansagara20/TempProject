using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ReportDefinition")]
    public class ReportDefinitionModel
    {
        public Int32 ReportNumber { get; set; } 
        public string Module { get; set; }
        public string SubModule { get; set; }
        public string ReportID { get; set; } 
        public string PermissionGroup { get; set; }
        public string Permission { get; set; }
        public string Description { get; set; }
        public string ReportFileName { get; set; }
        public Int16? PaperSize { get; set; }
        public Int32? Copies { get; set; }
        public Boolean Collate { get; set; }
        public Int32? PaperSource { get; set; }
        public string Note { get; set; }
        public Boolean Customized { get; set; }
        public string DocumentType { get; set; }
        public string ReportType { get; set; }
        public string ReportDefinition { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Boolean LegacyCSVExport { get; set; }
    }
}
