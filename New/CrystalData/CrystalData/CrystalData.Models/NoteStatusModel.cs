using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("NoteStatus")]
    public class NoteStatusModel
    {
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
