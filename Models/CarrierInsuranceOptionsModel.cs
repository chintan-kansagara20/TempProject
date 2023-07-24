using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("CarrierInsuranceOptions")]
    public class CarrierInsuranceOptionsModel
    {
        public string Carrier { get; set; }
        public string InsuranceOption { get; set; }
        public Boolean Insured { get; set; }
        public Boolean Active { get; set; }
    }
}
