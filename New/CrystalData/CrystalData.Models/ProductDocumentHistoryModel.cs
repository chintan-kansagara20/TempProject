using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductDocumentHistory")]
    public class ProductDocumentHistoryModel
    {
        public Guid? GUIDProduct { get; set; }
        public Boolean? Completed { get; set; }
        public string DocumentNumber { get; set; }
        public string Type { get; set; }
        public string BranchID { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DocumentStatus { get; set; }
        public string DocumentStatusCode { get; set; }
        public DateTime? RequestedShipDate { get; set; }
        public DateTime? ShipmentPromisedDate { get; set; }
        public string Warehouse { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string DisplayUnit { get; set; }
        public Decimal? DisplayQty { get; set; }
        public Decimal? QtyOrdered { get; set; }
        public Decimal? QtyShipped { get; set; }
        public Decimal? QtyScheduled { get; set; }
        public Decimal? QtyBackordered { get; set; }
        public Decimal? QtyOutstanding { get; set; }
        public Decimal? QtyInvoiced { get; set; }
        public string SoldToName { get; set; }
        public string LocationID { get; set; }
        public string DocumentBy { get; set; }
        public string SalespersonID { get; set; }
        public string Reference { get; set; }
        public string Reference2 { get; set; }
        public string Note { get; set; }
        public string LineType { get; set; }
        public Decimal? Price { get; set; }
        public Decimal? ForeignPrice { get; set; }
        public string PriceUnit { get; set; }
        public string Name { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string DocumentCategory { get; set; }
        public string DocumentType { get; set; }
        public Guid? GUIDCurrency { get; set; }
    }
}
