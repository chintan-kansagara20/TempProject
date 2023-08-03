using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("POInvoiceDetail")]
    public class POInvoiceDetailModel
    {
        public string Description { get; set; }
        public Guid? GUIDGLExpenseAccount { get; set; }
        public Decimal? LineAmount { get; set; }
        public Decimal? ForeignLineAmount { get; set; }
        public Int32 LineNumber { get; set; }
        public string LineType { get; set; }
        public string PONumber { get; set; }
        public Decimal? Price { get; set; }
        public Decimal? ForeignPrice { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public Decimal? Quantity { get; set; }
        public string SupplierProductID { get; set; }
        public string Unit { get; set; }
        public Guid GUIDPOInvoiceDetail { get; set; }
        public Guid GUIDPOInvoice { get; set; }
        public Guid? GUIDPODetail { get; set; }
        public Guid? GUIDTaxCode { get; set; }
        public Decimal? SalesTax { get; set; }
        public Decimal? ForeignSalesTax { get; set; }
        public string InvoiceNumber { get; set; }
        public string GLExpenseAccountID { get; set; }
        public string TaxCode { get; set; }
        public string TaxCodeDescription { get; set; }
    }
}
