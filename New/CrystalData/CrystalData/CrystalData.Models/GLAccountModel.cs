using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("GLAccount")]
    public class GLAccountModel
    {
        public Guid GUIDAccount { get; set; } 
        public string AccountListID { get; set; } 
        public Guid? GUIDParent { get; set; }
        public string Account { get; set; } 
        public Int32? AccountType { get; set; }
        public Int32? SpecialAccountType { get; set; }
        public string Description { get; set; }
        public string AccountNumber { get; set; }
        public Guid? GUIDCurrency { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public Boolean Active { get; set; }
        public string AccountSubType { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
    }
}
