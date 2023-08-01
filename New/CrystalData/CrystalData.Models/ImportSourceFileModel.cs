using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ImportSourceFile")]
    public class ImportSourceFileModel
    {
        public string TemplateID { get; set; } 
        public Int32 Source { get; set; } 
        public string FileType { get; set; }
        public string FilePath { get; set; }
        public Int32? RecordLength { get; set; }
        public Boolean LineFeed { get; set; }
        public string Delimiter { get; set; }
        public Boolean FirstRowFieldNames { get; set; }
        public string TextQualifier { get; set; }
        public string Table { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EncryptionKey { get; set; }
    }
}
