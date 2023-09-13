using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbActivityLog")]
    public class tbActivityLogModel
    {
        public Int32 PK { get; set; } 
        public Int32 ObjectType { get; set; } 
        public string Operation { get; set; } 
        public Guid? GUID { get; set; }
        public string OtherID { get; set; }
        public string Reference { get; set; }
        public DateTime Timestamp { get; set; } 
        public DateTime? TimeModified { get; set; }
        public Boolean FromOther { get; set; } = true;
    }
}
