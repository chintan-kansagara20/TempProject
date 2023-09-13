using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvVendorRequestForQuotes")]
    public class cvVendorRequestForQuotesModel
    {
        public string OrderNumber { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string CustomerID { get; set; }
        public string PONumber { get; set; }
        public string VendorID { get; set; }
        public string SupplierAddress2 { get; set; }
        public string SupplierCity { get; set; }
        public string SupplierState { get; set; }
        public string ProductId { get; set; }
        public string Description { get; set; }
        public Decimal? QuantityOrdered { get; set; }
        public Decimal? DisplayPrice { get; set; }
        public string SpecialInstructions { get; set; }
        public DateTime? DateEntered { get; set; }
        public string LastNote { get; set; }
        public string LastNoteDate { get; set; }
    }
}
