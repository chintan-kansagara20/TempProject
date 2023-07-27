using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyComponentLotAvailability")]
    public class cvAssemblyComponentLotAvailabilityModel
    {
        public Int32? DocumentNum { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategoryID { get; set; }
        public Decimal? AssemblyQuantityNeeded { get; set; }
        public Decimal? AssemblyQuantityConsumed { get; set; }
        public string LotNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Reference { get; set; }
        public string Specification { get; set; }
        public Decimal? AvailableOnHand { get; set; }
        public string AvailableWarehouseID { get; set; }
        public string AvailableLocation { get; set; }
        public string AllocatedLotNumber { get; set; }
        public Decimal? AllocatedOnHand { get; set; }
        public Decimal? IncomingTransferQuantity { get; set; }
        public Decimal? ReturnTransferQuantity { get; set; }
        public Guid? AllocatedGUIDLotSerial { get; set; }
        public string AllocatedWarehouse { get; set; }
        public string AllocatedLocation { get; set; }
        public Guid? AllocatedGUIDLocation { get; set; }
        public Guid? AllocatedGUIDWarehouse { get; set; }
        public Guid? AvailableGUIDLotSerial { get; set; }
        public Guid? AvailableGUIDWHLocation { get; set; }
        public Guid? AvailableGUIDWarehouse { get; set; }
    }
}
