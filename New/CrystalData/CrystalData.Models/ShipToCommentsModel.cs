using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ShipToComments")]
    public class ShipToCommentsModel
    {
        public string Comment { get; set; } 
        public Boolean Active { get; set; }
    }
}
