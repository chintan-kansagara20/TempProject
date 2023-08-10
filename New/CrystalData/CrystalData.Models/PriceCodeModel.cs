using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("PriceCode")]
    public class PriceCodeModel
    {
        public string PriceCode { get; set; } 
        public string Description { get; set; }
        public Boolean Active { get; set; }
    }
}
