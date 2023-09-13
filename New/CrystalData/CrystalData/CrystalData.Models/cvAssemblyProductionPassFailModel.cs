using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyProductionPassFail")]
    public class cvAssemblyProductionPassFailModel
    {
        public Int32? RegNumber { get; set; }
        public Int32 TransactionPassed { get; set; }
    }
}
