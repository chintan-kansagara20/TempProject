using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImpExpDocumentType")]
    public class ImpExpDocumentTypeModel
    {
        public string DocumentID { get; set; } 
        public string Description { get; set; }
        public Boolean Active { get; set; }
        public Boolean AllowInsert { get; set; }
        public Boolean AllowUpdateIgnoringBlanks { get; set; }
        public Boolean AllowUpdateIncludingBlanks { get; set; }
    }
}
