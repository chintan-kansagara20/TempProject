using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("YearMonth")]
    public class YearMonthModel
    {
        public Int32? Year { get; set; }
        public Int32? Month { get; set; }
        public DateTime? MonthBegin { get; set; }
        public DateTime? MonthEnd { get; set; }
    }
}
