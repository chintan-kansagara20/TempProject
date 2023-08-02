using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("MarketingCode")]
    public class MarketingCodeModel
    {
        public Guid GUIDMarketingCode { get; set; } 
        public string MarketingCode { get; set; }
        public string Description { get; set; }
        public Boolean Active { get; set; }
    }
}
