using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbOrderDetail")]
    public class tbOrderDetailModel
    {
        public Guid GUIDOrderDetail { get; set; }
        public Guid? GUIDOrder { get; set; }
        public Int32? LineNumber { get; set; }
        public Int32 SubLineNumber { get; set; } = ((0));
        public Int32 ComponentLevel { get; set; } = ((0));
        public string LineType { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string Description { get; set; }
        public Guid? GUIDSubstituteForProduct { get; set; }
        public Decimal? QtyOrdered { get; set; }
        public Decimal? QtyShipped { get; set; }
        public Decimal? QtyPicked { get; set; }
        public Decimal? QtyScheduled { get; set; }
        public Decimal? QtyInvoiced { get; set; }
        public Decimal? QtyBackordered { get; set; }
        public Boolean Completed { get; set; } = true;
        public Boolean LineCancelled { get; set; } = true;
        public string Unit { get; set; }
        public string DisplayUnit { get; set; }
        public Decimal? DisplayUnitFactor { get; set; }
        public string PriceCode { get; set; }
        public Decimal? Price { get; set; }
        public Decimal? DisplayPrice { get; set; }
        public Decimal? LineTaxPrice { get; set; }
        public string PriceUnit { get; set; }
        public Decimal? PriceUnitFactor { get; set; }
        public string PriceUnitFactorType { get; set; }
        public string ProductTaxID { get; set; }
        public string MiscChargeType { get; set; }
        public Boolean Freight { get; set; } = true;
        public Decimal? ProductTaxPct { get; set; }
        public Decimal? LineDiscountPct { get; set; }
        public Decimal? Amount { get; set; }
        public Decimal? DisplayAmount { get; set; }
        public Decimal? InvoiceDiscountAmount { get; set; }
        public Decimal? LineTaxAmount { get; set; }
        public Decimal? SchedAmount { get; set; }
        public Decimal? SchedInvoiceDiscountAmount { get; set; }
        public Decimal? SchedLineTaxAmount { get; set; }
        public Boolean Discountable { get; set; } = true;
        public Guid? GUIDTaxCode { get; set; }
        public Guid? GUIDProductClass { get; set; }
        public Decimal? Length { get; set; }
        public Decimal? Weight { get; set; }
        public Boolean VariableLength { get; set; } = true;
        public Boolean VariableWeight { get; set; } = true;
        public string Specification { get; set; }
        public string SpecialInstructions { get; set; }
        public string InvoiceComment { get; set; }
        public string Note { get; set; }
        public string InventoryControlType { get; set; }
        public Decimal? QtyLotSerial { get; set; }
        public string SalesCategory { get; set; }
        public Decimal? POPrice { get; set; }
        public Boolean CreatePO { get; set; } = true;
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
        public Boolean ToBeBilled { get; set; } = true;
        public Guid? GUIDWHLocation { get; set; }
        public Boolean Exported940 { get; set; } = true;
        public DateTime? Exported940Date { get; set; }
        public string WebOrderLineID { get; set; }
    }
}
