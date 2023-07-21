using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("cvAssemblyCustomerOrder")]
    public class cvAssemblyCustomerOrderModel
    {
        public Int32? RegNumber { get; set; }
        public string OrderNumber { get; set; }
        public string CustId { get; set; }
        public string SoldToName { get; set; }
        public string SoldToAddress1 { get; set; }
        public string SoldToAddress2 { get; set; }
        public string SoldToCity { get; set; }
        public string SoldToState { get; set; }
        public string SoldToCountry { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequestedShipDate { get; set; }
        public string SalespersonName { get; set; }
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public DateTime? RunDate { get; set; }
        public string OrderStatus { get; set; }
        public string OrderWorkflowStatus { get; set; }
        public Decimal? QtyOrdered { get; set; }
        public Decimal? QtyScheduled { get; set; }
        public Guid? GUIDOrderDetail { get; set; }
        public Guid? GUIDOrder { get; set; }
    }
}
