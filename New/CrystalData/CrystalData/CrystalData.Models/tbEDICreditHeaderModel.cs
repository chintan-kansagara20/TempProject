using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbEDICreditHeader")]
    public class tbEDICreditHeaderModel
    {
        public Int32 PKIDEDICreditHeader { get; set; }
        public string CreditDate { get; set; }
        public string CreditID { get; set; }
        public string TotalAmount { get; set; }
        public string CreditDebit { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string PODate { get; set; }
        public string PONumber { get; set; }
        public string TransType { get; set; }
        public string BuyerID { get; set; }
        public string CustomerID { get; set; }
    }
}
