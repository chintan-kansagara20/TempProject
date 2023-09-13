using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbDocument")]
    public class tbDocumentModel
    {
        public Guid GUIDDocument { get; set; } 
        public Guid? GUIDLink { get; set; }
        public string LinkType { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public Int32? FileSize { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public DateTime? DateAdded { get; set; }
        public string AddedBy { get; set; }
        public Byte[]? DocumentData { get; set; }
    }
}
