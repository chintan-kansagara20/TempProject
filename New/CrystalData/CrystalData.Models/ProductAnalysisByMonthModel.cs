using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductAnalysisByMonth")]
    public class ProductAnalysisByMonthModel
    {
        public Int32? Year { get; set; }
        public Int32? Month { get; set; }
        public DateTime? MonthBegin { get; set; }
        public DateTime? MonthEnd { get; set; }
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
