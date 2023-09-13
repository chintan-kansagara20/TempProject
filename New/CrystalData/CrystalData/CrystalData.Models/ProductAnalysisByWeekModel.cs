using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductAnalysisByWeek")]
    public class ProductAnalysisByWeekModel
    {
        public Int32? Year { get; set; }
        public Int32? Week { get; set; }
        public DateTime? WeekBegin { get; set; }
        public DateTime? WeekEnd { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string WarehouseID { get; set; }
        public Guid GUIDProduct { get; set; } 
        public string ProductID { get; set; } 
        public string Description { get; set; }
        public Decimal? DemandQty { get; set; }
        public Decimal? SalesQty { get; set; }
        public Double? AvgLeadTime { get; set; }
        public Decimal? CancelQty { get; set; }
        public Decimal? SupplyQty { get; set; }
        public Decimal? QtyOnHand { get; set; }
        public Decimal? OnHandValue { get; set; }
        public Decimal? COGSAmount { get; set; }
        public Decimal? SalesAmount { get; set; }
        public Int32? CustShipmentsRequested { get; set; }
        public Int32? CustShipmentsOnTime { get; set; }
        public Int32? VendorShipmentsRequested { get; set; }
        public Int32? VendorShipmentsOnTime { get; set; }
    }
}
