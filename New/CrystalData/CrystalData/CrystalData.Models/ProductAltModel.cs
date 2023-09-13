using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductAlt")]
    public class ProductAltModel
    {
        public Guid GUIDProduct { get; set; }
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public string AltProductID { get; set; }
        public string XrefType { get; set; }
        public string XrefTypeDescription { get; set; }
        public Guid? GUIDLink { get; set; }
        public string LinkDescription { get; set; }
        public Boolean Primary { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
    }
}
