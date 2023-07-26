using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbINVTransaction")]
    public class tbINVTransactionModel
    {
        public Int32 PKIDINVTransaction { get; set; }
        public Guid GUIDINVTransaction { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDToWarehouse { get; set; }
        public string DocumentType { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string AssemblyType { get; set; }
        public string VendorInvoiceID { get; set; }
        public Int32? GLTransactionNumber { get; set; }
        public Guid? GUIDGLInventoryAccount { get; set; }
        public Guid? GUIDGLOffsetAccount { get; set; }
        public Boolean PostedToGL { get; set; } = true;
        public Boolean PostedToAP { get; set; } = true;
        public Boolean PostedToINV { get; set; } = true;
        public Guid? GUIDVendor { get; set; }
        public string VendorName { get; set; }
        public string PONumber { get; set; }
        public Decimal ExchangeRate { get; set; } = 1;
        public string Reference { get; set; }
        public string Document { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public Int32? TransactionPeriod { get; set; }
        public Guid? GUIDProductionWorkflowStatus { get; set; }
        public Boolean TaxIncluded { get; set; } = true;
        public Boolean BeginningOfDay { get; set; } = true;
        public Decimal? InvoiceAmount { get; set; }
        public Decimal? SalesTax { get; set; }
        public Guid? GUIDInProgressUser { get; set; }
        public DateTime? InProgressDate { get; set; }
        public Guid? GUIDOrderDetail { get; set; }
    }
}
