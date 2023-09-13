using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyComponentAvailability")]
    public class cvAssemblyComponentAvailabilityModel
    {
        public Int32? DocumentNum { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string AOProductDescription { get; set; }
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public Decimal? AssemblyQuantityNeeded { get; set; }
        public Decimal? AssemblyQuantityConsumed { get; set; }
        public Decimal? AvailableOnHand { get; set; }
        public Decimal? AllocatedOnHand { get; set; }
        public string AllocatedWarehouse { get; set; }
        public string AllocatedLocation { get; set; }
        public Decimal? IncomingTransferQuantity { get; set; }
    }
}
