using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("POManagementSummary")]
    public class POManagementSummaryModel
    {
        public Guid GUIDPO { get; set; } 
        public string PONumber { get; set; }
        public string PONumberSort { get; set; }
        public string POStatus { get; set; } 
        public string StatusDate { get; set; }
        public string StatusChangedBy { get; set; }
        public string Type { get; set; }
        public string EnteredDate { get; set; }
        public string EnteredBy { get; set; }
        public string IssuedDate { get; set; }
        public string IssuedBy { get; set; }
        public string DueDate { get; set; }
        public string RequestedDeliveryDate { get; set; }
        public string DateCompleted { get; set; }
        public string RequestDate { get; set; }
        public string RequestedBy { get; set; }
        public string ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public string PromisedDeliveryDate { get; set; }
        public string NotBefore { get; set; }
        public string NotAfter { get; set; }
        public Boolean ReadyToPrint { get; set; }
        public Boolean Printed { get; set; }
        public string DatePrinted { get; set; }
        public string ShipVia { get; set; }
        public Int32? LineCount { get; set; }
        public Decimal? OrderedQty { get; set; }
        public Decimal? TotalAmount { get; set; }
        public Decimal? OutstandingQty { get; set; }
        public Decimal? OutstandingAmount { get; set; }
        public Decimal? ReceivedQty { get; set; }
        public Decimal? PercentReceived { get; set; }
        public Decimal? ReceivedAmount { get; set; }
        public Decimal? InvoicedQty { get; set; }
        public Decimal? PercentInvoiced { get; set; }
        public Decimal? InvoicedAmount { get; set; }
        public string VendorID { get; set; }
        public string VendorContact { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string VendorType { get; set; }
        public string Warehouse { get; set; }
        public string ShipName { get; set; }
        public string ShipAttention { get; set; }
        public string ShipAddress { get; set; }
        public string SalesOrder { get; set; }
        public string RelatedDoc { get; set; }
        public string FOB { get; set; }
        public string Reference { get; set; }
        public string SpecialInstructions { get; set; }
        public string TermsCode { get; set; }
        public string Currency { get; set; }
    }
}
