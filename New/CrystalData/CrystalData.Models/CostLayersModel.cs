using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CostLayers")]
    public class CostLayersModel
    {
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Int32? CostLayer { get; set; }
        public DateTime? LayerDate { get; set; }
        public string Unit { get; set; }
        public string CostUnit { get; set; }
        public Decimal? Amount { get; set; }
        public Decimal? OnHand { get; set; }
        public Int32? LayerClosed { get; set; }
    }
}
