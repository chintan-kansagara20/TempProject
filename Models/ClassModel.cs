using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Class")]
    public class ClassModel
    {
        public Guid GUIDClass { get; set; }
        public string ClassListID { get; set; }
        public Guid? GUIDParent { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
    }
}
