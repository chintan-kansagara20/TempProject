using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("INVTransaction")]
    public class INVTransactionModel
    {
        public string TransactionID { get; set; }
        public Int32 PKIDINVTransaction { get; set; } 
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public string DocumentType { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string AssemblyType { get; set; }
        public string VendorInvoiceID { get; set; }
        public Int32? GLTransactionNumber { get; set; }
        public Byte? PostedToGL { get; set; }
        public Byte? PostedToAP { get; set; }
        public Byte? PostedToINV { get; set; }
        public string VendorName { get; set; }
        public string PONumber { get; set; }
        public string Reference { get; set; }
        public string Document { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public Int32? TransactionPeriod { get; set; }
        public Guid? GUIDVendor { get; set; }
        public Guid? GUIDGLInventoryAccount { get; set; }
        public Guid? GUIDGLOffsetAccount { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDToWarehouse { get; set; }
        public Guid GUIDINVTransaction { get; set; } 
        public Guid? GUIDProductionWorkflowStatus { get; set; }
        public Byte? TaxIncluded { get; set; }
        public Boolean BeginningOfDay { get; set; }
        public Decimal ExchangeRate { get; set; } 
        public Decimal? InvoiceAmount { get; set; }
        public Decimal? ForeignInvoiceAmount { get; set; }
        public Decimal? SalesTax { get; set; }
        public Decimal? ForeignSalesTax { get; set; }
        public string GLInventoryAccount { get; set; }
        public string GLOffsetAccount { get; set; }
        public string Warehouse { get; set; }
        public string ToWarehouse { get; set; }
        public string ProductionWorkflowStatus { get; set; }
        public string ProductionWorkflowStatusAbbreviation { get; set; }
    }
}
