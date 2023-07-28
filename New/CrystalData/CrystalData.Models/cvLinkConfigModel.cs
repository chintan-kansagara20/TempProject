using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvLinkConfig")]
    public class cvLinkConfigModel
    {
        public string LinkDescription { get; set; }
        public string RecordTypeDescription { get; set; }
        public Int32? LinkActive { get; set; }
        public Guid GUIDLinkConfig { get; set; } 
        public Guid GUIDLinkRecordType { get; set; }
    }
}
