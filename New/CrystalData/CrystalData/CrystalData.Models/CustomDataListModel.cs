using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("CustomDataList")]
    public class CustomDataListModel
    {
        public string ListID { get; set; }
        public Int32 Sequence { get; set; }
        public string ListItem { get; set; }
    }
}
