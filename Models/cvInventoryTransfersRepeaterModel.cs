using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("cvInventoryTransfersRepeater")]
    public class cvInventoryTransfersRepeaterModel
    {
        public string TransactionID { get; set; }
        public Int32 PKIDINVTransaction { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string DocumentType { get; set; }
        public DateTime? DocumentDate { get; set; }
        public Boolean PostedToGL { get; set; }
        public Boolean PostedToAP { get; set; }
        public Boolean PostedToINV { get; set; }
        public string Reference { get; set; }
        public string Document { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDToWarehouse { get; set; }
        public Guid GUIDINVTransaction { get; set; }
        public string Warehouse { get; set; }
        public string ToWarehouse { get; set; }
        public Guid GUIDINVRegister { get; set; }
        public string VoidedBy { get; set; }
        public string OpenedBy { get; set; }
        public DateTime? RegDate { get; set; }
        public string FirstProduct { get; set; }
        public string Products { get; set; }
    }
}
