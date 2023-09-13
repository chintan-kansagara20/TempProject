using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbBarcodeType")]
    public class tbBarcodeTypeModel
    {
        public string BarcodeTypeID { get; set; }
        public string Description { get; set; }
    }
}
