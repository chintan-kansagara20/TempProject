using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImportSkipped")]
    public class ImportSkippedModel
    {
        public Guid GUIDSkipped { get; set; } 
        public Guid? GUIDTemplate { get; set; }
        public string DocumentType { get; set; }
        public string WebId { get; set; }
        public string WebInternalId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Note { get; set; }
        public string TemplateID { get; set; }
    }
}
