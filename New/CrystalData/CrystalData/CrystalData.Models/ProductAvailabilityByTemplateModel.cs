using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductAvailabilityByTemplate")]
    public class ProductAvailabilityByTemplateModel
    {
        public string TemplateID { get; set; }
        public Guid GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public string Description { get; set; }
        public string AlternateProductID { get; set; }
        public string UPC { get; set; }
        public Decimal? Available { get; set; }
        public string Unit { get; set; }
        public Decimal? AvailableInSalesUnits { get; set; }
        public DateTime? LastTransactionDate { get; set; }
        public DateTime? LastVoidedDate { get; set; }
        public DateTime? LastINVUpdatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string SalesUnit { get; set; }
        public Decimal? SalesUnitFactor { get; set; }
    }
}
