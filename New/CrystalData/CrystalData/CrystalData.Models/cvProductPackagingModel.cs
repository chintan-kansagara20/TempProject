using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductPackaging")]
    public class cvProductPackagingModel
    {
        public string PMProductID { get; set; } 
        public string PMDescription { get; set; }
        public string PMProductClassID { get; set; }
        public string PMProductClassDescription { get; set; }
        public string PMProductType { get; set; } 
        public string PMProductTypeDescription { get; set; }
        public string PMSalesCategory { get; set; }
        public string PMSalesCategoryDescription { get; set; }
        public Boolean PMActiveStatus { get; set; }
        public string PMMetrics { get; set; } 
        public string PMWebAddress { get; set; }
        public string PMTechSpec { get; set; }
        public Guid PMGUIDProduct { get; set; } 
    }
}
