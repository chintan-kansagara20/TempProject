using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbDocumentMgmtBar")]
    public class tbDocumentMgmtBarModel
    {
        public Guid GUIDDocumentMgmtBar { get; set; }
        public string DocType { get; set; }
        public string Description { get; set; }
        public string Definition { get; set; }
        public Boolean Custom { get; set; } = true;
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
