using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ReportAccessPermission")]
    public class ReportAccessPermissionModel
    {
        public string ReportID { get; set; } 
        public string LogonID { get; set; } 
        public string Module { get; set; }
        public string SubModule { get; set; }
        public string ReportFileName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string PermissionGroup { get; set; }
        public string AccessPermission { get; set; }
        public string DocumentType { get; set; }
        public Boolean? Hidden { get; set; }
        public Guid GUIDAccess { get; set; } 
    }
}
