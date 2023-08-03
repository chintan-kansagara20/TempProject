using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("OrderDetailLot")]
    public class OrderDetailLotModel
    {
        public Guid GUIDOrderDetailLot { get; set; } 
        public Guid? GUIDOrderDetail { get; set; }
        public Guid? GUIDOrder { get; set; }
        public string OrderNumber { get; set; }
        public string OrderStatus { get; set; }
        public Boolean OrderDetailCompleted { get; set; }
        public Guid? GUIDInvoiceDetail { get; set; }
        public Guid? GUIDInvoice { get; set; }
        public string InvoiceNumber { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public string Description { get; set; }
        public string LotNumber { get; set; } 
        public Decimal? Quantity { get; set; }
        public Decimal? DisplayQty { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public string Location { get; set; }
        public string Reference { get; set; }
        public string Specification { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Decimal? Weight { get; set; }
        public Decimal? Length { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public Int32 Completed { get; set; } 
    }
}
