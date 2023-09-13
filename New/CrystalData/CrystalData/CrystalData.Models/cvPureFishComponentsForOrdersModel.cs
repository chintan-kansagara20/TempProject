using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvPureFishComponentsForOrders")]
    public class cvPureFishComponentsForOrdersModel
    {
        public string OrderNumber { get; set; }
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public DateTime? RequestedShipDate { get; set; }
        public string FGProductDescription { get; set; }
        public Decimal? QtyOrdered { get; set; }
        public Decimal? QtyScheduled { get; set; }
        public string ComponentProductID { get; set; }
        public string ComponentDescription { get; set; }
        public Guid? ComponentGUIDProduct { get; set; }
    }
}
