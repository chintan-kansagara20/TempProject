using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("CarrierService")]
    public class CarrierServiceModel
    {
        public string Carrier { get; set; }
        public string CarrierService { get; set; }
        public string Description { get; set; }
        public Boolean Active { get; set; }
    }
}
