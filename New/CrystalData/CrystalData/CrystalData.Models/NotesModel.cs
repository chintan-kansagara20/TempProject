using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("Notes")]
    public class NotesModel
    {
        public Guid GUIDNotes { get; set; } 
        public Guid? GUIDLink { get; set; }
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
        public Byte Priority { get; set; } 
        public string EmailSubject { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public string EmailCc { get; set; }
        public string EmailBcc { get; set; }
        public string DocType { get; set; } 
        public string PriorityDescription { get; set; } 
        public string LinkedItemID { get; set; }
        public string LinkedItemDescription { get; set; }
        public string NoteTypeDescription { get; set; }
        public Int32? DocumentCount { get; set; }
    }
}
