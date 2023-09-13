using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductWarehouse")]
    public class ProductWarehouseModel
    {
        public Guid GUIDProductWarehouse { get; set; }
        public Guid GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string Warehouse { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public string Location { get; set; }
        public Decimal? PrimaryLocationStockingLevel { get; set; }
        public Decimal? UnitCost { get; set; }
        public Decimal? Value { get; set; }
        public Decimal? QtyReserved { get; set; }
        public Decimal? LastCost { get; set; }
        public Decimal? MgmtCost { get; set; }
        public Decimal? ReorderPoint { get; set; }
        public Decimal? StockingLevel { get; set; }
        public Decimal? QtyToReorder { get; set; }
        public DateTime? LastCountDate { get; set; }
        public string Note { get; set; }
        public Decimal? StdCost { get; set; }
        public Int32 CountInProgress { get; set; } 
        public Decimal? StandardCost { get; set; }
        public Boolean Deleted { get; set; }
    }
}
