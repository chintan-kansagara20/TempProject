using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvNegativeLotLocationNAHS")]
    public class cvNegativeLotLocationNAHSModel
    {
        public string ProductID { get; set; } 
        public string Description { get; set; }
        public string warehouse { get; set; }
        public string Location { get; set; }
        public string LotNumber { get; set; } 
        public Decimal? OnHand { get; set; }
        public Decimal? Available { get; set; }
    }
}
