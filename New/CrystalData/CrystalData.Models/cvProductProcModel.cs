using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductProc")]
    public class cvProductProcModel
    {
        public string ProcProductID { get; set; } 
        public string ProcDescription { get; set; }
        public string ProcProductType { get; set; } 
        public string ProcProductTypeDescription { get; set; }
        public string SalesCategory { get; set; }
        public string ProcSalesCategoryDescription { get; set; }
        public Boolean ProcActiveStatus { get; set; }
        public string ProcTechSpec { get; set; }
        public string ProcWebAddress { get; set; }
        public Guid ProcGUID { get; set; } 
    }
}
