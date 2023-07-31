using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("FlattenedKitComponents")]
    public class FlattenedKitComponentsModel
    {
        public Guid KitGUIDProduct { get; set; } 
        public Guid? ParentGUIDProduct { get; set; }
        public Guid GUIDProduct { get; set; } 
        public Int32 ComponentLevel { get; set; } 
        public string ProductID { get; set; } 
        public string Description { get; set; }
    }
}
