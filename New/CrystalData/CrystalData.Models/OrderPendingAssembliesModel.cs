using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("OrderPendingAssemblies")]
    public class OrderPendingAssembliesModel
    {
        public string OrderNumber { get; set; } 
        public Int32? LineNumber { get; set; }
        public string ProductID { get; set; }
        public Decimal? AssemblyQuantity { get; set; }
        public Guid? GUIDOrder { get; set; }
        public Guid GUIDOrderDetail { get; set; } 
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
    }
}
