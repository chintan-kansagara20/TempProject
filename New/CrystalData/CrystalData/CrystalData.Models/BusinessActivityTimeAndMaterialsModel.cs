using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("BusinessActivityTimeAndMaterials")]
    public class BusinessActivityTimeAndMaterialsModel
    {
        public Guid? GUIDIssue { get; set; }
        public string LineType { get; set; }
        public string LineTypeDescription { get; set; }
        public Int32 Billed { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string ProductID { get; set; }
        public Decimal? Quantity { get; set; }
        public string Unit { get; set; }
        public string BillingType { get; set; }
        public string Reference { get; set; }
        public string SpecialInstructions { get; set; }
        public string Description { get; set; }
        public string Warehouse { get; set; }
        public string PriceCode { get; set; }
        public Decimal? Price { get; set; }
        public string PriceUnit { get; set; }
        public Decimal? LineDiscountPct { get; set; }
        public Decimal? Amount { get; set; }
        public string Note { get; set; }
    }
}
