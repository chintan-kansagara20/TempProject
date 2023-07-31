using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvSuppManufactureYield")]
    public class cvSuppManufactureYieldModel
    {
        public Int32 DocumentNumber { get; set; } 
        public string FGProd { get; set; }
        public Decimal? FGYieldQty { get; set; }
        public Decimal? FGPlannedQty { get; set; }
        public Decimal? FGEstQty { get; set; }
        public string UnLabelledProd { get; set; }
        public Decimal? UnLabelledYieldQty { get; set; }
        public Decimal? UnLabelledPlannedQty { get; set; }
        public Decimal? UnLabelledConsumptionQty { get; set; }
        public Decimal? UnLabelledEstQty { get; set; }
        public string UnitProd { get; set; }
        public Decimal? UnitYieldQty { get; set; }
        public Decimal? UnitPlannedQty { get; set; }
        public Decimal? UnitConsumptionQty { get; set; }
        public Decimal? UnitEstQty { get; set; }
        public Decimal? UnitAverageMeasuredGM { get; set; }
        public Decimal? UnitLotWeightKG { get; set; }
        public Decimal? UnitsExpectedFromBlendWeight { get; set; }
        public string BatchProd { get; set; }
        public Decimal? BatchYieldQty { get; set; }
        public Decimal? BatchPlannedQty { get; set; }
        public Decimal? BatchConsumptionQty { get; set; }
        public Decimal? BatchEstQty { get; set; }
        public Int32 BlendActualLotWeightKG { get; set; } 
        public Int32 BlendEstWeightKG { get; set; } 
    }
}
