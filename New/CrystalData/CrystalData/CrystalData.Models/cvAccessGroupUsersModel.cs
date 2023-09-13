using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAccessGroupUsers")]
    public class cvAccessGroupUsersModel
    {
        public string GroupId { get; set; } 
        public string GroupName { get; set; }
        public string UserId { get; set; } 
        public string UserName { get; set; }
        public Guid GroupGUIDAccess { get; set; } 
        public Guid UserGuidAccess { get; set; } 
        public Guid GUIDAccessGroupUsers { get; set; } 
    }
}
