using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvIncomingInspectionBOM")]
    public class cvIncomingInspectionBOMModel
    {
        public Int32 BomLevel { get; set; }
        public string ProductID { get; set; }
        public string ComponentProductID { get; set; }
        public string ReceivedProductID { get; set; }
        public Int32? Sequence { get; set; }
        public string ComponentProductCategoryID { get; set; }
        public string ComponentAssemblyType { get; set; }
        public Guid GUIDProduct { get; set; }
        public Guid ComponentGUIDProduct { get; set; }
        public Guid GUIDReceivedProduct { get; set; }
    }
}
