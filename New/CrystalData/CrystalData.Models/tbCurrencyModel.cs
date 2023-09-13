using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbCurrency")]
    public class tbCurrencyModel
    {
        public Guid GUIDCurrency { get; set; } 
        public string CurrencyListID { get; set; } 
        public string Name { get; set; }
        public Boolean IsActive { get; set; } = true;
        public string CurrencyCode { get; set; }
        public string CurrencyFormat { get; set; }
        public Boolean UserDefined { get; set; } = true;
        public Decimal? ExchangeRate { get; set; }
        public DateTime? AsOfDate { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
    }
}
