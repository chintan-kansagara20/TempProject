using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbEDIPartnerOption")]
    public class tbEDIPartnerOptionModel
    {
        public Guid GUIDPartnerOption { get; set; } 
        public Guid GUIDPartner { get; set; } 
        public string OptionLabel { get; set; } 
        public string OptionValue { get; set; } 
        public string Comments { get; set; }
    }
}
