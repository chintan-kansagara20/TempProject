using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("PODetailSimple")]
    public class PODetailSimpleModel
    {
        public Decimal? AmountApproved { get; set; }
        public Boolean Complete { get; set; }
        public string Description { get; set; }
        public Guid? GUIDGLExpenseAccount { get; set; }
        public string GLExpenseAccountDescription { get; set; }
        public Decimal? LineAmount { get; set; }
        public Decimal? DisplayAmount { get; set; }
        public Int32 LineNumber { get; set; } 
        public string LineType { get; set; }
        public string Notes { get; set; }
        public Decimal? PriceInvoiced { get; set; }
        public Decimal? PriceRequested { get; set; }
        public Decimal? DisplayPrice { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public Decimal? QuantityInvoiceApproved { get; set; }
        public Decimal? QuantityOrdered { get; set; }
        public string SpecialInstructions { get; set; }
        public string SupplierProductID { get; set; }
        public string Unit { get; set; }
        public Guid GUIDPODetail { get; set; } 
        public Guid GUIDPO { get; set; } 
        public Guid? GUIDOrderDetail { get; set; }
        public Guid? GUIDTaxCode { get; set; }
        public Decimal? SalesTax { get; set; }
        public string DisplayUnit { get; set; }
        public Decimal? DisplayUnitFactor { get; set; }
        public Int32? LandedCostSession { get; set; }
        public Decimal? SalesTaxAmountApproved { get; set; }
        public Decimal? QuantityReceived { get; set; }
        public Decimal? QuantityOutstanding { get; set; }
        public Decimal? QuantityInvoiced { get; set; }
        public Decimal? AmountOpen { get; set; }
        public Decimal? AmountReceived { get; set; }
    }
}
