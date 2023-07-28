using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvLinkConfigDocuments")]
    public class cvLinkConfigDocumentsModel
    {
        public Guid GUIDLinkConfig { get; set; } 
        public string LinkDescription { get; set; }
        public string RecordTypeDescription { get; set; }
        public String EntityDescription { get; set; }
        public string EntityType { get; set; }
        public String filename { get; set; }
        public Guid GUIDLinkDocument { get; set; } 
        public String tags { get; set; }
        public String viewerURL { get; set; }
        public String downloadURL { get; set; }
        public string insertDateTime { get; set; }
        public string DMSName_obsolete { get; set; }
        public string DMSDocumentID { get; set; }
        public string DMSPath_obsolete { get; set; }
        public Guid? GUIDLinkDocumentSystem { get; set; }
        public Boolean? Guide { get; set; }
        public Guid GUIDEntity { get; set; } 
        public Guid GUIDLinkRecordType { get; set; } 
    }
}
