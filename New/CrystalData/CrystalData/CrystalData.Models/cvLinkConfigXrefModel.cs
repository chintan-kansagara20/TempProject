using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvLinkConfigXref")]
    public class cvLinkConfigXrefModel
    {
        public string LinkDescription { get; set; }
        public string RecordTypeDescription { get; set; }
        public string LinkType { get; set; }
        public Int32? LinkActive { get; set; }
        public string FormID { get; set; }
        public string FormService { get; set; }
        public string FormTitle { get; set; }
        public Byte? FormActive { get; set; }
        public string LabelDescription { get; set; }
        public string SourceView { get; set; }
        public string SourceRecordIDColumn { get; set; }
        public string PrinterNameCode { get; set; }
        public string PrintTrigger { get; set; }
        public string PrintService { get; set; }
        public string PrintInputType { get; set; }
        public String DocumentFilename { get; set; }
        public String DocumentViewerURL { get; set; }
        public string DocumentSystemNameForDocument { get; set; }
        public string DMSFolderName { get; set; }
        public Guid GUIDLinkConfig { get; set; } 
    }
}
