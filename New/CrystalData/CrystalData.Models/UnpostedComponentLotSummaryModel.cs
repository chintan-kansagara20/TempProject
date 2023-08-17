﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("UnpostedComponentLotSummary")]
    public class UnpostedComponentLotSummaryModel
    {
        public Guid GUIDProduct { get; set; } 
        public Guid? GUIDWarehouse { get; set; }
        public string LotNumber { get; set; } 
        public Decimal? Quantity { get; set; }
        public Guid GUIDINVLotSerial { get; set; } 
    }
}
