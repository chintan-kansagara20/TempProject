using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbCustomerContract")]
    public class tbCustomerContractModel
    {
        public Guid GUIDCustomerContract { get; set; } 
        public string ContractID { get; set; }
        public Guid? GUIDCustomer { get; set; }
        public Guid? GUIDContractType { get; set; }
        public string Description { get; set; }
        public string ShipToLocationID { get; set; }
        public DateTime? ContractBegin { get; set; }
        public DateTime? ContractEnd { get; set; }
        public string CustomerContact { get; set; }
        public string PO { get; set; }
        public Guid? GUIDTerms { get; set; }
        public Decimal? TradeDiscountPercent { get; set; }
        public Guid? GUIDPartner { get; set; }
        public string Note { get; set; }
        public string InvoiceText { get; set; }
    }
}
