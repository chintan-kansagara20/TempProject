using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductPackageUnitConversion")]
    public class cvProductPackageUnitConversionModel
    {
        public string ProductID { get; set; }
        public Guid GUIDProduct { get; set; }
        public Decimal PackageUnitFactor { get; set; }
        public string PackageUnit { get; set; }
        public string StockingUnit { get; set; }
    }
}
