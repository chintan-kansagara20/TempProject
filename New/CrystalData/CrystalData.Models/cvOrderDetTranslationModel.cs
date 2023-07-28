using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvOrderDetTranslation")]
    public class cvOrderDetTranslationModel
    {
        public string OrderNumber { get; set; } 
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public String TranslatedDescription { get; set; }
        public string OrderLanguage { get; set; }
        public string WebOrderID { get; set; }
        public Guid GUIDOrder { get; set; } 
        public Guid GUIDOrderDetail { get; set; } 
        public Guid? GUIDProduct { get; set; }
    }
}
