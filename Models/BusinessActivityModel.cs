using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("BusinessActivity")]
    public class BusinessActivityModel
    {
        public Guid GUIDIssue { get; set; }
        public string ActivityID { get; set; }
        public string ActivityIDSort { get; set; }
        public string ActivityType { get; set; }
        public string ActivityTypeCode { get; set; }
        public string CodeDescription { get; set; }
        public string Code { get; set; }
        public string Priority { get; set; }
        public string PriorityCode { get; set; }
        public string Resolution { get; set; }
        public string ResolutionCode { get; set; }
        public string Status { get; set; }
        public Boolean Completed { get; set; }
        public string StatusCode { get; set; }
        public string AssignedToName { get; set; }
        public string AssignedTo { get; set; }
        public DateTime? DateOpened { get; set; }
        public string OpenedBy { get; set; }
        public string OpenedByName { get; set; }
        public DateTime? DateDue { get; set; }
        public DateTime? DatePromised { get; set; }
        public string PromisedBy { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string AppointmentBy { get; set; }
        public DateTime? DateClosed { get; set; }
        public string ClosedByName { get; set; }
        public string ClosedBy { get; set; }
        public string Description { get; set; }
        public string Discussion { get; set; }
        public string ResolutionDiscussion { get; set; }
        public Decimal? EstimatedHours { get; set; }
        public Decimal? EstimatedAmount { get; set; }
        public string Reference { get; set; }
        public string Reference2 { get; set; }
        public DateTime? LastActionDate { get; set; }
        public string LastActionBy { get; set; }
        public string LastAction { get; set; }
        public string LastActionType { get; set; }
        public string _CurrentProductionControl { get; set; }
    }
}
