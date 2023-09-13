using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("VendorInfo")]
    public class VendorInfoModel
    {
        public Guid GUIDVendor { get; set; } 
        public string ContactName { get; set; } 
        public Boolean Subcontractor { get; set; }
        public DateTime? LiabilityInsuranceExpiration { get; set; }
        public DateTime? WorkersCompInsuranceExpiration { get; set; }
        public string Note { get; set; } 
        public string BarcodeTypeID { get; set; }
    }
}
