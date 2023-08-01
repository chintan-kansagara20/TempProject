using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("InvoiceDetail")]
    public class InvoiceDetailModel
    {
        public Guid GUIDInvoiceDetail { get; set; } 
        public Guid? GUIDInvoice { get; set; }
        public Int32? LineNumber { get; set; }
        public string LineType { get; set; }
        public string ProductID { get; set; }
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string Warehouse { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public Decimal? QtyOrdered { get; set; }
        public Decimal? DisplayQtyOrdered { get; set; }
        public Decimal? QtyShipped { get; set; }
        public Decimal? DisplayQtyShipped { get; set; }
        public Decimal? QtyInvoiced { get; set; }
        public Decimal? QtyBackOrdered { get; set; }
        public Decimal? DisplayQtyBackOrdered { get; set; }
        public Boolean LineCancelled { get; set; }
        public string Unit { get; set; }
        public string DisplayUnit { get; set; }
        public Decimal? DisplayUnitFactor { get; set; }
        public string PriceCode { get; set; }
        public Decimal? ForeignPrice { get; set; }
        public Decimal? Price { get; set; }
        public Decimal? ForeignDisplayPrice { get; set; }
        public Decimal? DisplayPrice { get; set; }
        public string PriceUnit { get; set; }
        public Decimal? LineDiscountPct { get; set; }
        public Decimal? ForeignLineTaxAmount { get; set; }
        public Decimal? LineTaxAmount { get; set; }
        public Decimal? ForeignAmount { get; set; }
        public Decimal? Amount { get; set; }
        public Decimal? ForeignDisplayAmount { get; set; }
        public Decimal? DisplayAmount { get; set; }
        public Boolean Discountable { get; set; }
        public Boolean? Taxable { get; set; }
        public string ProductTaxID { get; set; }
        public Decimal? ProductTaxPct { get; set; }
        public Decimal? ForeignLineTaxPrice { get; set; }
        public Decimal? LineTaxPrice { get; set; }
        public string ProductClass { get; set; }
        public Guid? GUIDSalesAccount { get; set; }
        public string SalesAccountID { get; set; }
        public Decimal? UnitCost { get; set; }
        public string CostUnit { get; set; }
        public Guid? GUIDCGSAccount { get; set; }
        public string CGSAccountID { get; set; }
        public Boolean CGSPostedToGL { get; set; }
        public string InvoiceComment { get; set; }
        public string SpecialInstructions { get; set; }
        public string Note { get; set; }
        public Int32? GLTransactionBatch { get; set; }
        public Decimal? ForeignInvoiceDiscountAmount { get; set; }
        public Decimal? InvoiceDiscountAmount { get; set; }
        public Decimal? ForeignSalesAmount { get; set; }
        public Decimal? SalesAmount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public Int32? TransactionPeriod { get; set; }
        public Int32? TransactionYear { get; set; }
        public Int32? GLTransactionLine { get; set; }
        public string MiscChargeType { get; set; }
        public Boolean Freight { get; set; }
        public Decimal? RetainagePercent { get; set; }
        public Decimal? RetainageAmount { get; set; }
        public Decimal? PercentCompleteThisBilling { get; set; }
        public Decimal? PercentCompleteLastBilling { get; set; }
        public Decimal? StoredMaterials { get; set; }
        public Decimal? ScheduledValue { get; set; }
        public Decimal? PreviousBilling { get; set; }
        public string ScheduleOfValuesCode { get; set; }
        public Decimal? PreviousChangeOrderAdditions { get; set; }
        public Decimal? PreviousChangeOrderDeductions { get; set; }
        public Decimal? CurrentChangeOrderAdditions { get; set; }
        public Decimal? CurrentChangeOrderDeductions { get; set; }
        public Decimal? PreviousRetainage { get; set; }
        public Guid? GUIDOrderDetail { get; set; }
        public Int32 SubLineNumber { get; set; } 
        public Int32 ComponentLevel { get; set; } 
        public Decimal? ComponentQuantity { get; set; }
        public Decimal? CGSAmountPostedToGL { get; set; }
        public Guid? GUIDClass { get; set; }
        public string InventoryControlType { get; set; }
        public Decimal? ForeignListPrice { get; set; }
        public Decimal? ListPrice { get; set; }
        public string ListPriceType { get; set; }
        public Decimal? MgmtCost { get; set; }
        public Decimal? AvgCost { get; set; }
        public Guid? GUIDEmployee { get; set; }
        public Guid? GUIDIssue { get; set; }
        public DateTime? ActivityDate { get; set; }
        public Guid? GUIDTaxCode { get; set; }
        public string BillingType { get; set; }
        public string EmployeeID { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string OrderNumber { get; set; }
        public string CurrentCGSAccountID { get; set; }
        public Decimal? CGSAmount { get; set; }
        public string CustomerProductID { get; set; }
        public string Class { get; set; }
        public Guid? GUIDProductClass { get; set; }
        public string TaxCode { get; set; }
        public string TaxCodeDescription { get; set; }
    }
}
