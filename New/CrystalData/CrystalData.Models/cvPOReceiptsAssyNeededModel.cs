using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvPOReceiptsAssyNeeded")]
    public class cvPOReceiptsAssyNeededModel
    {
        public string POLineItemRect { get; set; } 
        public string PONumber { get; set; }
        public string POStatus { get; set; }
        public string VendorID { get; set; }
        public string VendorName { get; set; }
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public Decimal? POQtyOutstanding { get; set; }
        public Decimal? POQtyOrdered { get; set; }
        public DateTime? DateIssued { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public Decimal? AmtReceived { get; set; }
        public DateTime? FirstDateNeeded { get; set; }
        public string NeededIn { get; set; }
    }
}
