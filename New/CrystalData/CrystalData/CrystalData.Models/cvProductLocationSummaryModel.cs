using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductLocationSummary")]
    public class cvProductLocationSummaryModel
    {
        public string productid { get; set; }
        public Int32? DocumentNumber { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public Decimal? PlannedAssemblyQty { get; set; }
        public Decimal? ActualAssemblyQty { get; set; }
        public string Warehouse { get; set; }
        public string LotNumber { get; set; }
        public Decimal? OnHand { get; set; }
        public Decimal? Available { get; set; }
        public string Location { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
