using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvLinkConfigDocumentFolders")]
    public class cvLinkConfigDocumentFoldersModel
    {
        public Guid GUIDLinkConfig { get; set; } 
        public string LinkDescription { get; set; }
        public string RecordTypeDescription { get; set; }
        public string EntityDescription { get; set; }
        public string EntityType { get; set; }
        public Guid GUIDLinkDocumentFolder { get; set; }
        public string DMSFolderName { get; set; }
        public String DMSFolderParameters { get; set; }
        public Guid? GUIDLinkDocumentSystem { get; set; }
        public string ViewNamingPattern { get; set; }
        public Boolean? ViewAllowed { get; set; }
        public string CreateNamingPattern { get; set; }
        public Boolean? CreateAllowed { get; set; }
        public Guid GUIDEntity { get; set; } 
        public Guid GUIDLinkRecordType { get; set; } 
    }
}
