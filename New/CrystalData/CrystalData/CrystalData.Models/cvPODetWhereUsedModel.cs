using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvPODetWhereUsed")]
    public class cvPODetWhereUsedModel
    {
        public string Document { get; set; }
        public string PONumber { get; set; }
        public string POStatus { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateIssued { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string VendorID { get; set; }
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public Decimal? POQtyOutstanding { get; set; }
        public Decimal? POQtyOrdered { get; set; }
        public Decimal? POQtyReceived { get; set; }
        public Decimal? QtyNeeded { get; set; }
        public Int32? RegNumber { get; set; }
        public string FGProductId { get; set; }
        public string FGDescription { get; set; }
        public Boolean PostedToINV { get; set; }
        public Guid? GUIDOrderDetail { get; set; }
        public string OrderNumber { get; set; }
        public string CompanyName { get; set; }
        public DateTime? RequestedShipDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public string SalesOrderStatus { get; set; }
        public Boolean PostedToGL { get; set; }
    }
}
