﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvPureFishOrderDetail")]
    public class cvPureFishOrderDetailModel
    {
        public string OrderNumber { get; set; }
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public DateTime? RequestedShipDate { get; set; }
        public string FGProductID { get; set; }
        public string FGProductDescription { get; set; }
        public Decimal? QtyNeeded { get; set; }
        public string ComponentProductID { get; set; }
        public string ComponentProductDescription { get; set; }
        public Decimal? QtyOrdered { get; set; }
        public Decimal? QtyScheduled { get; set; }
        public Decimal? OriginalOrderQuantity { get; set; }
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDOrder { get; set; }
        public Guid GUIDOrderDetail { get; set; } 
    }


}
