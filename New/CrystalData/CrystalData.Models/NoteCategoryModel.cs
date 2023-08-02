using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("NoteCategory")]
    public class NoteCategoryModel
    {
        public string Category { get; set; } 
        public string Description { get; set; } 
    }
}
