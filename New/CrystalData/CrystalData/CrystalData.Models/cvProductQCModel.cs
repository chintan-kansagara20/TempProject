using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductQC")]
    public class cvProductQCModel
    {
        public string ProductID { get; set; }
        public string Description { get; set; }
        public string ProductType { get; set; }
        public string ProductTypeDescription { get; set; }
        public string ProductClassID { get; set; }
        public string ProductClassDescription { get; set; }
        public string SalesCategory { get; set; }
        public string SalesCategoryDescription { get; set; }
        public Boolean ActiveStatus { get; set; }
        public string ControlGroup { get; set; }
        public string ControlMethod { get; set; }
        public string ControlSpec { get; set; }
        public string ControlDataType { get; set; }
        public string TechSpec { get; set; }
        public string WebAddress { get; set; }
        public string Unit { get; set; }
        public string ItemType { get; set; } 
        public Guid GUIDProduct { get; set; } 
    }
}
