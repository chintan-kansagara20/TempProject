using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("AccessPermissionMaster")]
    public class AccessPermissionMasterModel
    {
        public string PermissionGroup { get; set; }
        public string Permission { get; set; }
        public string Description { get; set; }
        public string Options { get; set; }
        public string Default { get; set; }
    }
}
