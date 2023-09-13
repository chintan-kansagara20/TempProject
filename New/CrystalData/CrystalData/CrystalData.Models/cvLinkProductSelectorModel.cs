using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvLinkProductSelector")]
    public class cvLinkProductSelectorModel
    {
        public string ProductID { get; set; } 
        public string ProductDescription { get; set; }
        public string LinkDescription { get; set; }
        public Int32? Active { get; set; }
        public string SelectorType { get; set; }
        public string RecordTypeDescription { get; set; }
        public Guid GUIDProduct { get; set; } 
        public Guid? GUIDLinkSelector { get; set; }
        public Guid? GUIDLinkRecordType { get; set; }
        public Guid? GUIDLinkConfig { get; set; }
        public Guid? GUIDLinkSelectorType { get; set; }
    }
}
