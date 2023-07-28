using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvPODetWithReceiptsAssyNeeded")]
    public class cvPODetWithReceiptsAssyNeededModel
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
        public DateTime? LastReceiptDate { get; set; }
        public DateTime? FirstDateNeeded { get; set; }
        public Int32? FirstAssemblyNumber { get; set; }
        public string NeededIn { get; set; }
        public Guid GUIDPODetail { get; set; } 
    }
}
