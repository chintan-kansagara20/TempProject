using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImportSourceRelateFields")]
    public class ImportSourceRelateFieldsModel
    {
        public string TemplateID { get; set; } 
        public Int32 Relation { get; set; } 
        public Int32 Row { get; set; } 
        public string Source1Field { get; set; }
        public string Source2Field { get; set; }
    }
}
