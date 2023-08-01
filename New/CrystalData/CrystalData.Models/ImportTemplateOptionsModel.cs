using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImportTemplateOptions")]
    public class ImportTemplateOptionsModel
    {
        public string TemplateID { get; set; } 
        public string OptionGroup { get; set; } 
        public string Option { get; set; } 
        public string Value { get; set; }
        public Int32 Override { get; set; } 
    }
}
