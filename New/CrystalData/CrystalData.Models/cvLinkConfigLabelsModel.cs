using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvLinkConfigLabels")]
    public class cvLinkConfigLabelsModel
    {
        public Guid GUIDLinkConfig { get; set; } 
        public string LinkDescription { get; set; }
        public string RecordTypeDescription { get; set; }
        public string EntityDescription { get; set; }
        public string EntityType { get; set; }
        public Guid GUIDLinkLabel { get; set; } 
        public Byte? Active { get; set; }
        public string SourceView { get; set; }
        public string SourceRecordIDColumn { get; set; }
        public string PrinterNameCode { get; set; }
        public string LabelID { get; set; }
        public string LabelDescription { get; set; }
        public Guid? PrintTriggerGUIDOptionValue { get; set; }
        public Guid? PrintServiceGUIDOptionValue { get; set; }
        public Guid? PrintInputTypeGUIDOptionValue { get; set; }
        public Guid GUIDEntity { get; set; }
        public Guid GUIDLinkRecordType { get; set; } 
    }
}
