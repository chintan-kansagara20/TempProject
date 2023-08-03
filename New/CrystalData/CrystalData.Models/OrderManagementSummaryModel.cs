using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("OrderManagementSummary")]
    public class OrderManagementSummaryModel
    {
        public Guid GUIDOrder { get; set; } 
        public string OrderNumber { get; set; } 
        public string OrderNumberSort { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ShipVia { get; set; }
        public string Carrier { get; set; }
        public string CarrierService { get; set; }
        public string FOB { get; set; }
        public DateTime? RequestedShipDate { get; set; }
        public DateTime? ShipmentPromisedDate { get; set; }
        public DateTime? ShipmentDueDate { get; set; }
        public DateTime? DontShipBefore { get; set; }
        public DateTime? DontShipAfter { get; set; }
        public string Type { get; set; }
        public string OrderStatus { get; set; }
        public string StatusBy { get; set; }
        public DateTime? StatusDate { get; set; }
        public string WorkflowStatus { get; set; }
        public string WorkflowBy { get; set; }
        public DateTime? WorkflowDate { get; set; }
        public string PO { get; set; }
        public string WebOrderNumber { get; set; }
        public string ShippingInstructions { get; set; }
        public string SpecialInstructions { get; set; }
        public string Comment { get; set; }
        public string Note { get; set; }
        public string Reference { get; set; }
        public string Reference2 { get; set; }
        public string Class { get; set; }
        public string SalespersonName { get; set; }
        public string LocationID { get; set; }
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactFax { get; set; }
        public string SoldToName { get; set; }
        public string CustomerType { get; set; }
        public string MarketingCode { get; set; }
        public string SoldToAddress { get; set; }
        public string SoldToAddress1 { get; set; }
        public string SoldToAddress2 { get; set; }
        public string SoldToAddress3 { get; set; }
        public string SoldToAddress4 { get; set; }
        public string SoldToCity { get; set; }
        public string SoldToState { get; set; }
        public string SoldToZip { get; set; }
        public string SoldToCountry { get; set; }
        public string ShipToAddress { get; set; }
        public string ShipToAttn { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToAddress3 { get; set; }
        public string ShipToAddress4 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToZip { get; set; }
        public string ShipToCountry { get; set; }
        public string CurrencyCode { get; set; }
        public Decimal? SubTotal { get; set; }
        public Decimal? TotalAmount { get; set; }
        public Decimal? SchedSubTotal { get; set; }
        public Decimal? Backordered { get; set; }
        public Int32? ScheduledCount { get; set; }
        public Int32? BackorderedCount { get; set; }
        public Int32? LineCount { get; set; }
        public Guid? GUIDOrderWorkFlowStatus { get; set; }
        public string OriginType { get; set; }
        public string OriginID { get; set; }
        public string BranchID { get; set; }
        public Int32 ScheduledIcon { get; set; } 
        public Int32 CreditWarningIcon { get; set; } 
        public Int32? ShipmentWarningIcon { get; set; }
        public Int32? PaymentWarningIcon { get; set; }
        public Int32 WarningIcon { get; set; } 
        public string EnteredBy { get; set; }
        public DateTime? EntryDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Boolean Printed { get; set; }
        public Boolean PickTicketPrinted { get; set; }
        public Boolean ShippingDocumentPrinted { get; set; }
        public string HoldStatus { get; set; }
        public Int32? PaymentAuthorizationCount { get; set; }
        public Decimal? AuthorizedAmount { get; set; }
        public Decimal? AmountPaid { get; set; }
        public string PaymentMethod { get; set; }
        public string Route { get; set; }
        public Decimal? StopNumber { get; set; }
        public string TermsCode { get; set; }
        public Int32? PicklistReadyToInvoiceCount { get; set; }
        public Int32? PicklistOpenCount { get; set; }
        public Int32? PicklistNotPickedCount { get; set; }
        public Int32? PicklistReadyToPackageCount { get; set; }
        public Int32? PicklistInvoicedCount { get; set; }
        public Int32? PicklistInProgressCount { get; set; }
        public Int32? PicklistOnHoldCount { get; set; }
        public DateTime? LastShipmentDate { get; set; }
        public Int32? UninvoicedPackageCount { get; set; }
        public Int32? ShipmentCreatedCount { get; set; }
        public Int32? ShipmentPackedCount { get; set; }
        public Int32? ShipmentShippedCount { get; set; }
        public Decimal? _PreShipmentDeposit { get; set; }
        public string _SalesLeadTime { get; set; }
        public string _ShippingTerms { get; set; }
    }
}
