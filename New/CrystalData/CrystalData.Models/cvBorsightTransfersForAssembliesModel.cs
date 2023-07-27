using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvBorsightTransfersForAssemblies")]
    public class cvBorsightTransfersForAssembliesModel
    {
        public string Reference { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public Int32? DocumentNumber { get; set; }
        public string ProductID { get; set; }
        public Decimal? AssemblyQuantity { get; set; }
        public Decimal? Quantity { get; set; }
        public Int32 IncomingTransferQuantityUnpostedDocument { get; set; }
        public Int32 IncomingTransferQuantityPostedDocument { get; set; }
        public Decimal? IncomingTransferQuantityUnpostedSession { get; set; }
        public Decimal? IncomingTransferQuantityPostedSession { get; set; }
        public string OrderNumber { get; set; }
        public string ParentJobCustID { get; set; }
        public string ParentCustID { get; set; }
        public Guid GUIDINVTransaction { get; set; }
        public Guid GUIDINVTransactionDetail { get; set; }
        public Int32 PKIDINVTransactionDetail { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string CustID { get; set; }
        public Guid? GUIDParent { get; set; }
    }
}
