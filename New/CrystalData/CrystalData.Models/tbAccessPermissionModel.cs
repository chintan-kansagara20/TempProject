using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbAccessPermission")]
    public class tbAccessPermissionModel
    {
        public Guid GUIDAccessPermission { get; set; }
        public Guid GUIDAccess { get; set; } 
        public string PermissionGroup { get; set; } 
        public string Permission { get; set; } 
        public string Option { get; set; } 
    }
}
