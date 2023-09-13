using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvIssueAssembly")]
    public class cvIssueAssemblyModel
    {
        public string AssignedTo { get; set; }
        public string ClosedBy { get; set; }
        public Boolean? Completed { get; set; }
        public string Contact { get; set; }
        public DateTime? DateClosed { get; set; }
        public DateTime? DateDue { get; set; }
        public DateTime? DateOpened { get; set; }
        public DateTime? DatePromised { get; set; }
        public DateTime? DateResolved { get; set; }
        public string Description { get; set; }
        public string Discussion { get; set; }
        public string Email { get; set; }
        public Guid? GUIDCustomer { get; set; }
        public Guid? GUIDIssue { get; set; }
        public Guid? GUIDIssueCode { get; set; }
        public Guid? GUIDIssueType { get; set; }
        public Guid? GUIDIssueXref { get; set; }
        public Guid? GUIDLink { get; set; }
        public Guid? GUIDLocation { get; set; }
        public Guid? GUIDOrder { get; set; }
        public Guid? GUIDPO { get; set; }
        public Guid? GUIDPriorityCode { get; set; }
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDResolutionCode { get; set; }
        public Guid? GUIDStatusCode { get; set; }
        public Guid? GUIDVendor { get; set; }
        public string IssueCode { get; set; }
        public string IssueCodeDescription { get; set; }
        public string IssueID { get; set; }
        public string IssueStatus { get; set; }
        public string IssueType { get; set; }
        public string IssueTypeDescription { get; set; }
        public string OpenedBy { get; set; }
        public string IssueOrderNumber { get; set; }
        public string Phone { get; set; }
        public string PONumber { get; set; }
        public string PriorityCode { get; set; }
        public string PriorityCodeDescription { get; set; }
        public string ProductDescription { get; set; }
        public string ProductID { get; set; }
        public string PromisedBy { get; set; }
        public string IssueReference { get; set; }
        public string IssueReference2 { get; set; }
        public string ResolutionCode { get; set; }
        public string ResolutionCodeDescription { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public string StatusCode { get; set; }
        public string StatusCodeDescription { get; set; }
        public string SupplierName { get; set; }
        public Int32? TreePosition { get; set; }
        public Int32? Session { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string AOReference { get; set; }
        public string Document { get; set; }
        public string OrderNumber { get; set; }
        public string CustId { get; set; }
        public string ProductionWorkflowStatus { get; set; } 
        public string AOProductId { get; set; }
        public string AOProductDescription { get; set; }
        public string FProductID { get; set; }
        public string FProductDescription { get; set; }
        public string LotNumber { get; set; }
        public string ActivityLink { get; set; }
        public string AssignedToName { get; set; }
    }
}
