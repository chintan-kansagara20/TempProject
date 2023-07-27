using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvInventorySerialLotSummaryTransactions")]
    public class cvInventorySerialLotSummaryTransactionsModel
    {
        public string ProductID { get; set; } 
        public string LotNumber { get; set; } 
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public string Zone { get; set; }
        public Int32? LocationSequence { get; set; }
        public Decimal? OnHand { get; set; }
        public Decimal? Available { get; set; }
        public DateTime? LastReceiptDate { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public Int32? PKIDINVTransactionDetail { get; set; }
        public string TransactionType { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string OrderNumber { get; set; }
        public Decimal? Quantity { get; set; }
        public Boolean? PostedToINV { get; set; }
        public Boolean? PostedToGL { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Reference { get; set; }
        public string Specification { get; set; }
        public Guid? GUIDINVTransactionDetail { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public Guid? GUIDToWHLocation { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
    }
}
