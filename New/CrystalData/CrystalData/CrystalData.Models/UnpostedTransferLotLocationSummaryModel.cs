﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("UnpostedTransferLotLocationSummary")]
    public class UnpostedTransferLotLocationSummaryModel
    {
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public string LotNumber { get; set; } 
        public Decimal? Quantity { get; set; }
    }
}
