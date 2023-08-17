using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("TaxCatDefinition")]
    public class TaxCatDefinitionModel
    {
        public Guid GUIDTaxCategory { get; set; } 
        public Guid GUIDTaxID { get; set; } 
    }
}
