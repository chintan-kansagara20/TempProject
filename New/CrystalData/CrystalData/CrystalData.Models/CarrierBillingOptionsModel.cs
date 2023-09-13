using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CarrierBillingOptions")]
    public class CarrierBillingOptionsModel
    {
        public Boolean Active { get; set; }
        public string BillingOption { get; set; }
        public string Carrier { get; set; }
        public Boolean FreightCollect { get; set; }
    }
}
