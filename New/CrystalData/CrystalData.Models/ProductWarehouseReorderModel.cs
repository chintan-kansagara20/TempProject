using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductWarehouseReorder")]
    public class ProductWarehouseReorderModel
    {
        public Guid GUIDProduct { get; set; } 
        public string ProductID { get; set; } 
        public string Description { get; set; }
        public string ProductClass { get; set; }
        public string SalesCategory { get; set; }
        public string PurchaseUnit { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string Warehouse { get; set; }
        public Decimal? Available { get; set; }
        public Decimal? QtyOnHand { get; set; }
        public Decimal? QuantityOnOrder { get; set; }
        public Decimal? QtyReserved { get; set; }
        public string Unit { get; set; }
        public Decimal? ReorderPoint { get; set; }
        public Decimal? StockingLevel { get; set; }
        public Decimal? AvgCost { get; set; }
        public Decimal? LastCost { get; set; }
        public Decimal? MgmtCost { get; set; }
        public Decimal? RecOrderQty { get; set; }
        public Guid? PreferredGUIDVendor { get; set; }
        public string PreferredVendorName { get; set; }
        public string PreferredVendorProductID { get; set; }
        public Decimal? PreferredPrice { get; set; }
        public string PreferredUnit { get; set; }
        public Decimal? PreferredLastCost { get; set; }
        public Int32? PreferredLeadTime { get; set; }
        public Guid? ReorderGUIDVendor { get; set; }
        public string ReorderVendorName { get; set; }
        public string ReorderVendorProductID { get; set; }
        public Decimal? ReorderQty { get; set; }
        public Decimal? ReorderCost { get; set; }
        public string ReorderUnit { get; set; }
        public Decimal? ReorderLastCost { get; set; }
        public Int32? ReorderLeadTime { get; set; }
    }
}
