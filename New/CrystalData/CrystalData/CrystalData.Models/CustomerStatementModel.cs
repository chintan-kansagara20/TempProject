using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerStatement")]
    public class CustomerStatementModel
    {
        public Guid? GUIDCustomer { get; set; }
        public Guid GUIDTransaction { get; set; } 
        public DateTime? TransactionDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string DocumentID { get; set; }
        public string DocumentTypeID { get; set; }
        public string DocumentType { get; set; }
        public Decimal? ForeignAmount { get; set; }
        public Decimal? Amount { get; set; }
        public Decimal? ForeignBalance { get; set; }
        public Decimal? ForeignBalanceWithVoided { get; set; }
        public Decimal? Balance { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
    }
}
