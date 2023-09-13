using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("Import")]
    public class ImportModel
    {
        public Guid GUIDTemplate { get; set; } 
        public string TemplateID { get; set; } 
        public string TemplateName { get; set; }
        public string Description { get; set; }
        public string DocumentID { get; set; }
        public Boolean Add { get; set; }
        public Boolean Update { get; set; }
        public Boolean UpdateWithBlanks { get; set; }
        public Boolean Active { get; set; }
        public Int32? LastPosition { get; set; }
        public Boolean ScriptEnable { get; set; }
        public string ScriptCommand { get; set; }
        public string ScriptFilename { get; set; }
        public Byte[]? ScriptBlob { get; set; }
        public Boolean SkipValidation { get; set; }
    }
}
