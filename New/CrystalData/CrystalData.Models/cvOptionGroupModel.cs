using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvOptionGroup")]
    public class cvOptionGroupModel
    {
        public Guid GUIDctbOptionGroup { get; set; } 
        public string VOptionGroup { get; set; }
    }
}
