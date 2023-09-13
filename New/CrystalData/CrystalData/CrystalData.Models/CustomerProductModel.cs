using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerProduct")]
    public class CustomerProductModel
    {
        public Guid? GUIDOrder { get; set; }
        public string OrderNumber { get; set; }
        public Guid GUIDInvoice { get; set; }
        public string InvoiceNumber { get; set; }
        public string PO { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceType { get; set; }
        public string SalespersonID { get; set; }
        public Guid? GUIDCustomer { get; set; }
        public string ContractID { get; set; }
        public string CustomerID { get; set; }
        public string LocationID { get; set; }
        public string MarketingCode { get; set; }
        public string InvoiceNote { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public string LineType { get; set; }
        public string Warehouse { get; set; }
        public Decimal? QtyShipped { get; set; }
        public Decimal? DisplayQtyShipped { get; set; }
        public Decimal? QtyInvoiced { get; set; }
        public string Unit { get; set; }
        public string DisplayUnit { get; set; }
        public Decimal? DisplayUnitFactor { get; set; }
        public string PriceCode { get; set; }
        public Decimal? Price { get; set; }
        public string PriceUnit { get; set; }
        public Decimal? LineDiscountPct { get; set; }
        public string Description { get; set; }
        public string ProductClass { get; set; }
        public string Note { get; set; }
        public Int32 SubLineNumber { get; set; }
        public string InventoryControlType { get; set; }
        public string LotNumber { get; set; }
        public Guid? GUIDOrderDetailLot { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public Guid? GUIDWarehouse { get; set; }
    }
}
