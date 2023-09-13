using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbAccessPermissionMaster")]
    public class tbAccessPermissionMasterModel
    {
        public string PermissionGroup { get; set; }
        public string Permission { get; set; }
        public string Description { get; set; }
        public string Options { get; set; }
        public string Default { get; set; }
    }
}
