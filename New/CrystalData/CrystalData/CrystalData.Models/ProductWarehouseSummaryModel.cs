using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductWarehouseSummary")]
    public class ProductWarehouseSummaryModel
    {
        public Guid GUIDProductWarehouse { get; set; }
        public Guid GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string Warehouse { get; set; }
        public string WarehouseDescription { get; set; }
        public string ProductID { get; set; }
        public Decimal? QtyReserved { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public string Location { get; set; }
        public Decimal? PrimaryLocationStockingLevel { get; set; }
        public Decimal? LastCost { get; set; }
        public Decimal? MgmtCost { get; set; }
        public Decimal? StandardCost { get; set; }
        public Decimal? ReorderPoint { get; set; }
        public Decimal? StockingLevel { get; set; }
        public Decimal? QtyToReorder { get; set; }
        public DateTime? LastCountDate { get; set; }
        public string Note { get; set; }
        public Decimal? QtyOnHand { get; set; }
        public Decimal? OnHandValue { get; set; }
        public Decimal? AvgCost { get; set; }
        public Decimal? QuantityOnPO { get; set; }
        public Decimal? QuantityOnReturn { get; set; }
        public Decimal? QuantityOnOrder { get; set; }
        public Decimal? AmountOnOrder { get; set; }
        public Decimal? QtyOrdered { get; set; }
        public Decimal? QtyBooked { get; set; }
        public Decimal? QtyScheduled { get; set; }
        public Decimal? QtyBackordered { get; set; }
        public Decimal? QtySpecialOrder { get; set; }
        public Decimal? UnpostedComponentQuantity { get; set; }
        public Decimal? UnpostedAssemblyQuantity { get; set; }
        public Decimal? UnpostedTransferQuantity { get; set; }
        public Decimal? QtyOrderedAmount { get; set; }
        public Decimal? QtySchedAmount { get; set; }
        public Decimal? Allocated { get; set; }
        public Decimal? Available { get; set; }
        public DateTime? LastTransactionDate { get; set; }
        public Decimal? QtyRequired { get; set; }
        public Decimal? StdCost { get; set; }
        public string ProductType { get; set; }
        public string SalesCategory { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string ProductClassID { get; set; }
        public string ProductClassDescription { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
        public Boolean ReorderIncludeInPO { get; set; }
        public Guid? ReorderGUIDVendor { get; set; }
        public string ReorderUnit { get; set; }
        public Decimal? ReorderCost { get; set; }
        public Decimal? ReorderQty { get; set; }
        public string ReorderVendorProductID { get; set; }
        public Decimal? BuildQty { get; set; }
        public Boolean BuildChecked { get; set; }
        public Boolean Deleted { get; set; }
    }
}
