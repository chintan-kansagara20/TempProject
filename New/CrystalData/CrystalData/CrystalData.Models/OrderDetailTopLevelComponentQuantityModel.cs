using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("OrderDetailTopLevelComponentQuantity")]
    public class OrderDetailTopLevelComponentQuantityModel
    {
        public Guid? GUIDOrder { get; set; }
        public Guid GUIDOrderDetail { get; set; }
        public Decimal? TopLevelComponentQuantity { get; set; }
    }
}
