using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("VendorType")]
    public class VendorTypeModel
    {
        public Guid GUIDVendorType { get; set; }
        public string VendorTypeListID { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public Boolean Active { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeModified { get; set; }
    }
}
