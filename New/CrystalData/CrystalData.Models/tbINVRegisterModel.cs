using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbINVRegister")]
    public class tbINVRegisterModel
    {
        public Int32 PKIDINVRegister { get; set; }
        public Guid GUIDINVRegister { get; set; }
        public Int32? RegNumber { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Source { get; set; }
        public string OpenedBy { get; set; }
        public string Description { get; set; }
        public Decimal? Amount { get; set; }
        public Boolean PostedToINV { get; set; } = true;
        public string PostedToINVBy { get; set; }
        public DateTime? DatePostedToINV { get; set; }
        public Boolean PostedToGL { get; set; } = true;
        public string PostedToGLBy { get; set; }
        public DateTime? DatePostedToGL { get; set; }
        public Boolean PostedToAP { get; set; } = true;
        public string PostedToAPBy { get; set; }
        public DateTime? DatePostedToAP { get; set; }
        public string Note { get; set; }
        public Int32? GLTransactionBatch { get; set; }
        public Int16? TransactionPeriod { get; set; }
        public Int16? TransactionYear { get; set; }
        public Int32? ParentRegNumber { get; set; }
        public Guid? GUIDLandedCostPODetail { get; set; }
        public DateTime? VoidedDate { get; set; }
        public string VoidedBy { get; set; }
        public Guid? GUIDOrder { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }

    public class tbINVRegisterViewModel 
    {
        public Int32? RegNumber { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Source { get; set; }
        public string OpenedBy { get; set; }
        public string Description { get; set; }
        public Decimal? Amount { get; set; }
        public Boolean PostedToINV { get; set; } = true;
        public string PostedToINVBy { get; set; }
        public DateTime? DatePostedToINV { get; set; }
        public Boolean PostedToGL { get; set; } = true;
        public string PostedToGLBy { get; set; }
        public DateTime? DatePostedToGL { get; set; }
        public Boolean PostedToAP { get; set; } = true;
        public string PostedToAPBy { get; set; }
        public DateTime? DatePostedToAP { get; set; }
        public string Note { get; set; }
        public Int32? GLTransactionBatch { get; set; }
        public Int16? TransactionPeriod { get; set; }
        public Int16? TransactionYear { get; set; }
        public Int32? ParentRegNumber { get; set; }
        public Guid? GUIDLandedCostPODetail { get; set; }
        public Guid? GUIDOrder { get; set; }
    }
}
