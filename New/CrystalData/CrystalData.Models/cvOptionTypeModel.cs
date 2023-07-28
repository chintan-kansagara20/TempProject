using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvOptionType")]
    public class cvOptionTypeModel
    {
        public Guid GUIDctbOptionType { get; set; }
        public string VOptionType { get; set; }
    }
}
