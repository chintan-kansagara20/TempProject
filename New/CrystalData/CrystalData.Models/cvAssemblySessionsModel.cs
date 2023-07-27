using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblySessions")]
    public class cvAssemblySessionsModel
    {
        public Int32? Session { get; set; }
    }
}
