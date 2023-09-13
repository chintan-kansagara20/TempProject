using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvRoleAccess")]
    public class cvRoleAccessModel
    {
        public Guid GUIDAccess { get; set; }
        public string ID { get; set; }
        public Guid GUIDRole { get; set; }
        public string RoleName { get; set; }
    }
}
