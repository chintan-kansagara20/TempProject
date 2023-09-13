using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("EDIAdditionalInformation")]
    public class EDIAdditionalInformationModel
    {
        public Guid GUIDAdditionalInformation { get; set; } 
        public Guid? GUIDLink { get; set; }
        public string InformationType { get; set; } 
        public string ID { get; set; }
        public Int32? SortOrder { get; set; }
        public string Value { get; set; }
    }
}
