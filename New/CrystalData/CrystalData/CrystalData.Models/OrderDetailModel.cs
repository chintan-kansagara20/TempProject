using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("OrderDetail")]
    public class OrderDetailModel
    {
        public Guid GUIDOrderDetail { get; set; }
        public Guid? GUIDOrder { get; set; }
        public Int32? LineNumber { get; set; }
        public Int32 SubLineNumber { get; set; }
        public Int32 ComponentLevel { get; set; }
        public string LineType { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public Decimal? QtyOrdered { get; set; }
        public Decimal? QtyShipped { get; set; }
        public Decimal? QtyPicked { get; set; }
        public Decimal? QtyScheduled { get; set; }
        public Decimal? QtyInvoiced { get; set; }
        public Decimal? QtyBackordered { get; set; }
        public Boolean Completed { get; set; }
        public Boolean LineCancelled { get; set; }
        public string Unit { get; set; }
        public string PriceCode { get; set; }
        public Decimal? ForeignPrice { get; set; }
        public Decimal? Price { get; set; }
        public string PriceUnit { get; set; }
        public Decimal? PriceUnitFactor { get; set; }
        public string PriceUnitFactorType { get; set; }
        public string ProductTaxID { get; set; }
        public string MiscChargeType { get; set; }
        public Boolean Freight { get; set; }
        public Decimal? ProductTaxPct { get; set; }
        public Decimal? LineDiscountPct { get; set; }
        public Decimal? ForeignAmount { get; set; }
        public Decimal? Amount { get; set; }
        public Decimal? ForeignInvoiceDiscountAmount { get; set; }
        public Decimal? InvoiceDiscountAmount { get; set; }
        public Decimal? ForeignLineTaxAmount { get; set; }
        public Decimal? LineTaxAmount { get; set; }
        public Decimal? ForeignSchedAmount { get; set; }
        public Decimal? SchedAmount { get; set; }
        public Decimal? ForeignSchedInvoiceDiscountAmount { get; set; }
        public Decimal? SchedInvoiceDiscountAmount { get; set; }
        public Decimal? ForeignSchedLineTaxAmount { get; set; }
        public Decimal? SchedLineTaxAmount { get; set; }
        public Boolean Discountable { get; set; }
        public Boolean? Taxable { get; set; }
        public Decimal? Length { get; set; }
        public Decimal? Weight { get; set; }
        public Boolean VariableLength { get; set; }
        public Boolean VariableWeight { get; set; }
        public string Specification { get; set; }
        public string SpecialInstructions { get; set; }
        public string InvoiceComment { get; set; }
        public string Note { get; set; }
        public string InventoryControlType { get; set; }
        public Decimal? QtyLotSerial { get; set; }
        public string SalesCategory { get; set; }
        public Decimal? POPrice { get; set; }
        public Boolean CreatePO { get; set; }
        public Decimal? ComponentQuantity { get; set; }
        public Guid? GUIDParentOrderDetail { get; set; }
        public Guid? GUIDVendor { get; set; }
        public Guid? GUIDPODetail { get; set; }
        public Guid? GUIDClass { get; set; }
        public Guid? GUIDIssue { get; set; }
        public string Reference { get; set; }
        public DateTime? ActivityDate { get; set; }
        public Guid? GUIDEmployee { get; set; }
        public string BillingType { get; set; }
        public Boolean ToBeBilled { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public Guid? GUIDProductClass { get; set; }
        public Guid? GUIDTaxCode { get; set; }
        public string DisplayUnit { get; set; }
        public Decimal? DisplayUnitFactor { get; set; }
        public string PackageUnit { get; set; }
        public Decimal? PackageUnitFactor { get; set; }
        public Decimal? ForeignDisplayPrice { get; set; }
        public Decimal? DisplayPrice { get; set; }
        public Decimal? ForeignLineTaxPrice { get; set; }
        public Decimal? LineTaxPrice { get; set; }
        public Decimal? ForeignDisplayAmount { get; set; }
        public Decimal? DisplayAmount { get; set; }
        public Guid? GUIDSubstituteForProduct { get; set; }
        public Boolean Exported940 { get; set; }
        public DateTime? Exported940Date { get; set; }
        public string SubstituteForProductID { get; set; }
        public Decimal? DisplayQtyOrdered { get; set; }
        public Decimal? DisplayQtyScheduled { get; set; }
        public Decimal? DisplayQtyBackOrdered { get; set; }
        public Decimal? DisplayQtyPicked { get; set; }
        public Decimal? DisplayQtyShipped { get; set; }
        public Decimal? DisplayQtyInvoiced { get; set; }
        public Decimal? DisplayQtyOutstanding { get; set; }
        public string ProductClass { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public string EmployeeID { get; set; }
        public Decimal? QtyOutstanding { get; set; }
        public string OrderNumber { get; set; }
        public string VendorPO { get; set; }
        public Int32? VendorPOLine { get; set; }
        public string POVendorID { get; set; }
        public DateTime? LastShipmentDate { get; set; }
        public Decimal? PrevInvoiceAmount { get; set; }
        public Guid? CurrentCGSAccountID { get; set; }
        public string CustomerProductID { get; set; }
        public string Class { get; set; }
        public string TaxCode { get; set; }
        public string TaxCodeDescription { get; set; }
    }
}
