using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbEDIImportLog")]
    public class tbEDIImportLogModel
    {
        public Int32 PKIDEDIImportLog { get; set; }
        public string PO { get; set; }
        public string Store { get; set; }
        public string MemoNumber { get; set; }
        public string ProductID { get; set; }
        public string Error { get; set; }
    }
}
