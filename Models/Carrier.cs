﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Carrier")]
    public class CarrierModel
    {
        public string Carrier { get; set; }
        public string Description { get; set; }
        public string CarrierType { get; set; }
        public string AccountNumber { get; set; }
        public string SCACCode { get; set; }
        public string URL { get; set; }
        public Boolean Active { get; set; }
    }
}
