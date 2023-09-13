using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("Messages")]
    public class MessagesModel
    {
        public Int32 PKIDMessages { get; set; } 
        public string Title { get; set; }
        public string EmailFrom { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string NoteLocation { get; set; }
        public Int32? NoteType { get; set; }
        public string NoteText { get; set; }
        public Guid? GUIDAccess { get; set; }
        public string MessageType { get; set; }
        public string EmailCc { get; set; }
        public string EmailBcc { get; set; }
    }
}
