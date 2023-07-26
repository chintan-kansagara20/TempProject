﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomerInvoiceTotal")]
    public class CustomerInvoiceTotalModel
    {
        public Guid? GUIDCustomer { get; set; }
        public Decimal? TotalAmount { get; set; }
        public Decimal? SubTotal { get; set; }
        public Int64? Count { get; set; }
    }
}
