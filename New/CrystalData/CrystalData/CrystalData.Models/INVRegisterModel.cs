using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("INVRegister")]
    public class INVRegisterModel
    {
        public Int32 PKIDINVRegister { get; set; } 
        public Int32? RegNumber { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Source { get; set; }
        public string OpenedBy { get; set; }
        public string Description { get; set; }
        public Decimal? Amount { get; set; }
        public Byte? PostedToINV { get; set; }
        public string PostedToINVBy { get; set; }
        public DateTime? DatePostedToINV { get; set; }
        public Byte? PostedToGL { get; set; }
        public string PostedToGLBy { get; set; }
        public DateTime? DatePostedToGL { get; set; }
        public Byte? PostedToAP { get; set; }
        public string PostedToAPBy { get; set; }
        public DateTime? DatePostedToAP { get; set; }
        public string Note { get; set; }
        public Int32? GLTransactionBatch { get; set; }
        public Int16? TransactionPeriod { get; set; }
        public Int16? TransactionYear { get; set; }
        public Guid GUIDINVRegister { get; set; } 
        public Int32? ParentRegNumber { get; set; }
        public Guid? GUIDLandedCostPODetail { get; set; }
    }
}
