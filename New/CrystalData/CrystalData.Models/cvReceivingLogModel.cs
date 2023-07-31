using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvReceivingLog")]
    public class cvReceivingLogModel
    {
        public string LotNumber { get; set; }
        public string ActivityID { get; set; } 
        public Int32? RegNumber { get; set; }
        public string PONumber { get; set; }
        public string ActivityDescription { get; set; }
        public string ActivityCurrentAssignTo { get; set; }
        public Boolean? Completed { get; set; }
        public string ActivityStatus { get; set; } 
        public string Resolution { get; set; }
        public DateTime? DateClosed { get; set; }
        public string Reference { get; set; }
        public string VendorName { get; set; }
        public string ProductID { get; set; } 
        public Decimal? QuantityOrdered { get; set; }
        public string ProductDescription { get; set; }
        public string ReceivingDescription { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string ActivityDiscussion { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Decimal? RectQuantity { get; set; }
        public string Unit { get; set; }
        public string LotSpec { get; set; }
        public string ActivityType { get; set; }
        public string VendorId { get; set; }
        public Guid? ixlotGuidLink { get; set; }
        public Guid? ixrecGuidLink { get; set; }
        public Guid? GUIDIssue { get; set; }
        public Guid? GUIDPODetail { get; set; }
    }
}
