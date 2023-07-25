using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("CostLayerIssues")]
    public class CostLayerIssuesModel
    {
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Int32? CostLayer { get; set; }
        public Decimal? QtyIssued { get; set; }
        public Decimal? AmtIssued { get; set; }
    }
}
