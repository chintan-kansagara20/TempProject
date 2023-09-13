using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("PicklistDetail")]
    public class PicklistDetailModel
    {
        public Guid GUIDPicklist { get; set; } 
        public Guid GUIDPicklistDetail { get; set; } 
        public Guid GUIDOrder { get; set; } 
        public Guid GUIDOrderDetail { get; set; } 
        public Decimal? QtyPicked { get; set; }
        public Decimal? WeightPicked { get; set; }
        public Decimal? LengthPicked { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public Int32? Sequence { get; set; }
        public Decimal? Weight { get; set; }
        public Decimal? Length { get; set; }
        public Decimal? QtyToPick { get; set; }
        public DateTime? PickedDate { get; set; }
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public string ProductID { get; set; }
        public string Description { get; set; }
        public string PriceUnit { get; set; }
        public string PriceFactorBasis { get; set; }
        public string Unit { get; set; }
        public string InventoryControlType { get; set; }
        public string UPC { get; set; }
        public string AlternateProductID { get; set; }
        public string PicklistID { get; set; }
        public string PicklistStatus { get; set; }
        public Int32 Open { get; set; } 
        public string OrderNumber { get; set; } 
        public DateTime? OrderDate { get; set; }
        public string Warehouse { get; set; }
        public Int32? OrderSequence { get; set; }
        public string OrderID { get; set; }
        public string Location { get; set; }
        public string Position { get; set; }
        public string Zone { get; set; }
        public Guid? GUIDInvoice { get; set; }
    }
}
