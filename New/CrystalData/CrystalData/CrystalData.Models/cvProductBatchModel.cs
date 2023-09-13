using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductBatch")]
    public class cvProductBatchModel
    {
        public string BlendProductID { get; set; } 
        public string BlendDescription { get; set; }
        public string BlendProductType { get; set; } 
        public string BlendProductTypeDescription { get; set; }
        public string BlendSalesCategory { get; set; }
        public string ProductCategory { get; set; }
        public Boolean BlendActiveStatus { get; set; }
        public Guid BlendProductGUID { get; set; } 
    }
}
