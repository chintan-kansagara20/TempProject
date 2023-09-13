using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbCustomerShipNotes")]
    public class tbCustomerShipNotesModel
    {
        public Guid GUIDLocation { get; set; }
        public Boolean? PopupNotes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Comment { get; set; }
    }
}
