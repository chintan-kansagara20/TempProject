using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbEDIDiscountsAndCharges")]
    public class tbEDIDiscountsAndChargesModel
    {
        public Guid GUIDDiscountsAndCharges { get; set; } 
        public Guid? GUIDLink { get; set; }
        public string InformationType { get; set; } 
        public Int32? LineNumber { get; set; }
        public string Code { get; set; }
        public string MethodOfHandling { get; set; }
        public Decimal? Value { get; set; }
        public Decimal? Percentage { get; set; }
    }
}
