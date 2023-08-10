using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbINVTransactionDetail")]
    public class tbINVTransactionDetailModel
    {
        public Guid GUIDINVTransactionDetail { get; set; }
        public Int32 PKIDINVTransactionDetail { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public string TransactionType { get; set; }
        public string PONumber { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public string VendorProductID { get; set; }
        public string Description { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public Decimal? QuantityOrdered { get; set; }
        public Decimal? Quantity { get; set; }
        public Decimal? ComponentQuantity { get; set; }
        public Decimal? AssemblyComponentQuantity { get; set; }
        public Decimal? AssemblyQuantity { get; set; }
        public Decimal? QuantityRejected { get; set; }
        public string Unit { get; set; }
        public string DisplayUnit { get; set; }
        public Decimal? DisplayUnitFactor { get; set; }
        public Decimal? ValueDiscrepancy { get; set; }
        public Decimal? UnitCost { get; set; }
        public string CostUnit { get; set; }
        public Decimal? Amount { get; set; }
        public Decimal? FreezeCount { get; set; }
        public Decimal? PhysicalCount { get; set; }
        public Int32? CountLineNumber { get; set; }
        public string Location { get; set; }
        public string ToLocation { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public Guid? GUIDToWHLocation { get; set; }
        public Boolean PostedToINV { get; set; } = false;
        public Boolean PostedToAP { get; set; } = false;
        public Boolean PostedToGL { get; set; } = false;
        public string Note { get; set; }
        public Int32? InvoiceLineNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Int32? CostLayer { get; set; }
        public DateTime? PostedTimestamp { get; set; }
        public Int32? TransactionLine { get; set; }
        public Int32? GLTransactionBatch { get; set; }
        public Int32? TransactionPeriod { get; set; }
        public Int32? TransactionYear { get; set; }
        public Int32? GLTransactionLine { get; set; }
        public Decimal? AmountPostedToGL { get; set; }
        public Guid? GUIDJournal { get; set; }
        public Guid? GUIDDebitAccount { get; set; }
        public Guid? GUIDCreditAccount { get; set; }
        public Guid? GUIDInvoiceDetail { get; set; }
        public Guid? GUIDOrderDetailLot { get; set; }
        public Guid? GUIDPODetail { get; set; }
        public Boolean PriorPeriodAdjustment { get; set; } = false;
        public string FromCostMethod { get; set; }
        public string ToCostMethod { get; set; }
        public Boolean DoNotSync { get; set; } = false;
        public Guid? GUIDTaxCode { get; set; }
        public Decimal? SalesTax { get; set; }
        public Guid? GUIDLayerBatch { get; set; }
        public Guid? GUIDAssociatedITD { get; set; }
    }
}
