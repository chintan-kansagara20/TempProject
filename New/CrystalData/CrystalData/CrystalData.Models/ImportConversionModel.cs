using EasyCrudLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImportConversion")]
    public class ImportConversionModel
    {
        public string TemplateID { get; set; } 
        public string SubdocumentID { get; set; } 
        public string Destination { get; set; } 
        public string FromValue { get; set; } 
        public string ToValue { get; set; } 
        public Int32 Override { get; set; } 
    }
}
