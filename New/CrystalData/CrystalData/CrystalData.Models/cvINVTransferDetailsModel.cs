using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvINVTransferDetails")]
    public class cvINVTransferDetailsModel
    {
        public Int32 PKIDINVTransactionDetail { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public string TransactionType { get; set; }
        public Guid? GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string LotNumber { get; set; }
        public string LotSerialReference { get; set; }
        public string LotSerialSpecification { get; set; }
        public Decimal? Quantity { get; set; }
        public string Unit { get; set; }
        public Decimal? UnitCost { get; set; }
        public Decimal? ForeignUnitCost { get; set; }
        public string CostUnit { get; set; }
        public Decimal? Amount { get; set; }
        public Decimal? ForeignAmount { get; set; }
        public string Location { get; set; }
        public string ToLocation { get; set; }
        public Byte? PostedToINV { get; set; }
        public string VoidedBy { get; set; }
        public DateTime? VoidedDate { get; set; }
        public string Note { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public Int32? TransactionLine { get; set; }
        public Int32? TransactionPeriod { get; set; }
        public Int32? TransactionYear { get; set; }
        public string FromCostMethod { get; set; }
        public string ToCostMethod { get; set; }
        public string DisplayUnit { get; set; }
        public Decimal? DisplayUnitFactor { get; set; }
        public Decimal? DisplayQuantity { get; set; }
        public Decimal? DisplayUnitCost { get; set; }
        public Decimal? ForeignDisplayUnitCost { get; set; }
        public string Warehouse { get; set; }
        public string TransactionTypeDescription { get; set; }
        public Guid? GUIDAssociatedITD { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public Guid GUIDINVTransactionDetail { get; set; }
        public Guid? GUIDOrderDetailLot { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public Guid? GUIDToWHLocation { get; set; }
        public Guid? GUIDTaxCode { get; set; }
    }
}
