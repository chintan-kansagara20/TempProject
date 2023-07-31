using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("EDIOrderDetailEx")]
    public class EDIOrderDetailExModel
    {
        public Guid GUIDOrderDetail { get; set; }
        public string LineNumber { get; set; }
        public Decimal? QtyOrdered { get; set; }
        public string Unit { get; set; }
        public Decimal? Price { get; set; }
        public string BuyerProductID { get; set; }
        public string VendorProductID { get; set; }
        public string UPCProductID { get; set; }
        public string ProductDescription { get; set; }
        public Int32? CaseSize { get; set; }
        public string CaseUnit { get; set; }
        public Boolean CreatedShipInfo { get; set; }
        public DateTime? CreatedShipInfoDate { get; set; }
        public string ListPrice { get; set; }
    }
}
