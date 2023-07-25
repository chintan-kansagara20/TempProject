using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("CarrierVoidOptions")]
    public class CarrierVoidOptionsModel
    {
        public string Carrier { get; set; }
        public string VoidOption { get; set; }
        public Boolean Voided { get; set; }
        public Boolean Active { get; set; }
    }
}
