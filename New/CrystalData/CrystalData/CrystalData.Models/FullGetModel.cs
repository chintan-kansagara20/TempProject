using EasyCrudLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    public class FullGetModel
    {
        public int page { get; set; }
        public int itemsPerPage { get; set; }
        public List<OrderByModel>? orderBy { get; set; }
        public List<AdvanceFilterByModel>? filtersList { get; set; }
    }
}
