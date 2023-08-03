using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
        [Table("OrderDetailSummary")]
        public class OrderDetailSummaryModel
        {
            public Guid? GUIDProduct { get; set; }
            public string ProductID { get; set; } 
            public string Warehouse { get; set; }
            public Decimal? QtyOrdered { get; set; }
            public Decimal? QtyShipped { get; set; }
            public Decimal? QtyScheduled { get; set; }
            public Decimal? QtyBackordered { get; set; }
            public Decimal? QtyInvoiced { get; set; }
            public Decimal? QtyOrderedAmount { get; set; }
            public Decimal? QtySchedAmount { get; set; }
            public Decimal? QtyRequired { get; set; }
            public Decimal? QtyBooked { get; set; }
            public Decimal? QtySpecialOrder { get; set; }
            public DateTime? LastTransactionDate { get; set; }
        }
}
