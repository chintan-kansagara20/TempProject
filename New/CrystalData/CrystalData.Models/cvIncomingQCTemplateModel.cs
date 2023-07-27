using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvIncomingQCTemplate")]
    public class cvIncomingQCTemplateModel
    {
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public Guid GUIDProduct { get; set; }
        public string ProductCategory { get; set; }
        public string ProductCategoryID { get; set; }
        public string ComponentProductID { get; set; }
        public string ComponentProductDescription { get; set; }
        public Guid ComponentGUIDProduct { get; set; }
        public Decimal? Quantity { get; set; }
        public string ComponentProductCategory { get; set; }
        public string ComponentProductCategoryID { get; set; }
        public Int32? Sequence { get; set; }
    }
}
