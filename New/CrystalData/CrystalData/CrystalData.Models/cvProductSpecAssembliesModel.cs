using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductSpecAssemblies")]
    public class cvProductSpecAssembliesModel
    {
        public Int32? RegNumber { get; set; }
        public string Description { get; set; }
        public string Document { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string ProductID { get; set; }
    }
}
