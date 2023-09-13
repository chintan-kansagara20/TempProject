using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvIssueChangedAssignment")]
    public class cvIssueChangedAssignmentModel
    {
        public string IssueID { get; set; }
        public string Description { get; set; }
        public string ChangedBy { get; set; }
        public string ChangedFrom { get; set; }
        public string DataChanged { get; set; }
        public DateTime? DateTime { get; set; }
        public string Employee { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedToName { get; set; }
        public DateTime? DateDue { get; set; }
        public DateTime? DatePromised { get; set; }
        public DateTime? DateOpened { get; set; }
        public DateTime? DateClosed { get; set; }
        public string ClosedBy { get; set; }
        public Boolean? Completed { get; set; }
        public string Discussion { get; set; }
        public string Reference { get; set; }
        public string IssueType { get; set; }
        public string IssueTypeDescription { get; set; }
        public string StatusCode { get; set; }
        public string IssueStatusDescription { get; set; }
        public string PriorityCode { get; set; }
        public string PriorityDescription { get; set; }
        public string Note { get; set; }
        public Int32? RegNumber { get; set; }
        public string ActivityLink { get; set; }
        public Guid GUIDEventLog { get; set; } 
        public Guid? GUIDIssue { get; set; }
        public Guid? GUIDStatusCode { get; set; }
    }
}
