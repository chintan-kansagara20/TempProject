using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvPriorPOForProduct")]
    public class cvPriorPOForProductModel
    {
        public string ProductID { get; set; }
        public Decimal? QuantityOrdered { get; set; }
        public Decimal? DisplayPrice { get; set; }
        public DateTime? DateIssued { get; set; }
        public Guid GUIDProduct { get; set; } 
        public Guid GUIDPODetail { get; set; } 
        public Guid GUIDPO { get; set; } 
    }
}
