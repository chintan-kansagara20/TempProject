using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbCustomField")]
    public class tbCustomFieldModel
    {
        public Guid GUIDCustomField { get; set; }
        public string TableID { get; set; }
        public string TableName { get; set; }
        public Int32 Sequence { get; set; }
        public string Label { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public string Extra { get; set; }
    }
}
