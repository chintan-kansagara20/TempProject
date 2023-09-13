using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("YearWeek")]
    public class YearWeekModel
    {
        public Int32? Year { get; set; }
        public Int32? Week { get; set; }
        public DateTime? WeekBegin { get; set; }
        public DateTime? WeekEnd { get; set; }
    }
}
