using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Charge")]
    public class ChargeModel
    {
        public Guid GUIDCharge { get; set; }
        public string TxnID { get; set; }
        public Guid? GUIDCustomer { get; set; }
        public DateTime? TxnDate { get; set; }
        public string RefNumber { get; set; }
        public string ItemRef { get; set; }
        public Decimal? Quantity { get; set; }
        public Decimal? Rate { get; set; }
        public Decimal? Amount { get; set; }
        public Decimal? BalanceRemaining { get; set; }
        public string Description { get; set; }
        public Guid? GUIDAccount { get; set; }
        public string ClassRef { get; set; }
        public DateTime? BilledDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string Type { get; set; }
        public Guid? GUIDCurrency { get; set; }
        public string CurrencyCode { get; set; }
    }
}
