using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbAccessPermissionGroup")]
    public class tbAccessPermissionGroupModel
    {
        public string PermissionGroup { get; set; }
        public string Description { get; set; }
    }
}
