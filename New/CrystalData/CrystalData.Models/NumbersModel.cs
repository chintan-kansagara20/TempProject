using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("Numbers")]
    public class NumbersModel
    {
        public string NumberType { get; set; } 
        public Int32? NextNumber { get; set; }
        public Int32? LowNumber { get; set; }
        public Int32? HighNumber { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public Boolean NoWrap { get; set; }
    }
}
