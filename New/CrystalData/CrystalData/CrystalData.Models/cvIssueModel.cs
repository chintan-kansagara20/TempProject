using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvIssue")]
    public class cvIssueModel
    {
        public string IssueIDSort { get; set; }
        public Guid GUIDIssue { get; set; } 
        public string IssueID { get; set; }
        public Guid? GUIDIssueType { get; set; }
        public Guid? GUIDStatusCode { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public Boolean Completed { get; set; }
        public Guid? GUIDIssueCode { get; set; }
        public Guid? GUIDResolutionCode { get; set; }
        public string AssignedTo { get; set; }
        public Int32? AssignedOrder { get; set; }
        public DateTime? DateOpened { get; set; }
        public string OpenedBy { get; set; }
        public DateTime? DateDue { get; set; }
        public DateTime? DatePromised { get; set; }
        public string PromisedBy { get; set; }
        public Decimal? EstimatedHours { get; set; }
        public DateTime? WorkAroundDate { get; set; }
        public string WorkAroundBy { get; set; }
        public DateTime? DateResolved { get; set; }
        public string ResolvedBy { get; set; }
        public DateTime? DateClosed { get; set; }
        public string ClosedBy { get; set; }
        public string Description { get; set; }
        public string Discussion { get; set; }
        public string ResolutionDiscussion { get; set; }
        public Guid? GUIDPriorityCode { get; set; }
        public Decimal? EstimatedAmount { get; set; }
        public string Reference { get; set; }
        public string Reference2 { get; set; }
        public Boolean TaxIncluded { get; set; }
        public string _CurrentProductionControl { get; set; }
        public string IssueType { get; set; }
        public string StatusCode { get; set; }
        public Guid? GUIDIssueXref { get; set; }
        public string IssueCode { get; set; }
        public string IssueCodeDescription { get; set; }
        public string PriorityCode { get; set; }
        public string PriorityCodeDescription { get; set; }
        public string IssueTypeDescription { get; set; }
        public Guid? GUIDLink { get; set; }
        public Int32? TreePosition { get; set; }
        public string XrefType { get; set; }
        public Boolean? PrimaryReference { get; set; }
        public string Contact { get; set; }
        public Boolean? AddressOverride { get; set; }
        public string ContactName { get; set; }
        public string ContactAddress { get; set; }
        public string ContactAddress2 { get; set; }
        public string ContactAddress3 { get; set; }
        public string ContactAddress4 { get; set; }
        public string ContactCity { get; set; }
        public string ContactState { get; set; }
        public string ContactZip { get; set; }
        public string ContactCountry { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string ContactNote { get; set; }
        public string ResolutionCode { get; set; }
        public string ResolutionCodeDescription { get; set; }
        public string IssueStatus { get; set; }
        public string StatusCodeDescription { get; set; }
        public Guid? GUIDCustomer { get; set; }
        public string CustomerId { get; set; }
        public string CustomerCompanyName { get; set; }
        public string CustomerContactName { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public Guid? GUIDLocation { get; set; }
        public string LocationID { get; set; }
        public string LocationName { get; set; }
        public Guid? GUIDOrder { get; set; }
        public string OrderNumber { get; set; }
        public string SoldToName { get; set; }
        public Guid? GUIDPO { get; set; }
        public string PONumber { get; set; }
        public string SupplierName { get; set; }
        public Guid? SecondaryGUIDIssue { get; set; }
        public string SecondaryIssueID { get; set; }
        public string SecondaryIssueDescription { get; set; }
        public Guid? GUIDVendor { get; set; }
        public string FormLink { get; set; }
    }
}
