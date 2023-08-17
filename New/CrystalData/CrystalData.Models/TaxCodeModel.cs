using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("TaxCode")]
    public class TaxCodeModel
    {
        public Guid GUIDTaxCode { get; set; }
        public string TaxCodeListID { get; set; }
        public string Name { get; set; }
        public Boolean Active { get; set; }
        public Boolean Taxable { get; set; }
        public Guid? SalesGUIDTaxCategory { get; set; }
        public Guid? PurchaseGUIDTaxCategory { get; set; }
        public string Description { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
    }
}
