using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("Year")]
    public class YearModel
    {
        public Int32? Year { get; set; }
        public DateTime? YearBegin { get; set; }
        public DateTime? YearEnd { get; set; }
    }
}
