using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAccessGroup")]
    public class cvAccessGroupModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public Guid GroupGUIDAccess { get; set; }
    }
}
