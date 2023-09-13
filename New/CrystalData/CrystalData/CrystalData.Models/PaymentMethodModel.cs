using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("PaymentMethod")]
    public class PaymentMethodModel
    {
        public Guid GUIDPaymentMethod { get; set; } 
        public string PaymentMethodListID { get; set; } 
        public string Name { get; set; }
        public Boolean Active { get; set; }
        public DateTime TimeCreated { get; set; } 
        public DateTime TimeModified { get; set; } 
        public Boolean? IsCreditCard { get; set; }
        public Boolean? IsECheck { get; set; }
        public Boolean? IsCheck { get; set; }
        public Int32 PaymentType { get; set; } 
        public string TypeName { get; set; }
    }
}
