using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvOptions")]
    public class cvOptionsModel
    {
        public string OptionGroup { get; set; }
        public string OptionType { get; set; }
        public string OptionValue { get; set; }
        public Byte? Active { get; set; }
        public Byte? DefaultValue { get; set; }
        public string OptionKey { get; set; }
        public string ValueDescription { get; set; }
        public Guid GUIDOptionGroup { get; set; } 
        public Guid GUIDctbOptionType { get; set; } 
        public Guid GUIDctbOptionValue { get; set; } 
    }
}
