using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("NotesView")]
    public class NotesViewModel
    {
        public Guid? GUIDLink { get; set; }
        public Guid? GUIDCustomer { get; set; }
        public string LocationID { get; set; }
        public Int32? OrderNumber { get; set; }
        public string ProductID { get; set; }
        public string PONumber { get; set; }
        public string NoteType { get; set; }
        public DateTime? ReminderDate { get; set; }
        public DateTime? DateAdded { get; set; }
        public string AddedBy { get; set; }
        public string Note { get; set; }
        public string AssignedTo { get; set; }
        public Boolean Completed { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public Byte? Priority { get; set; }
    }
}
