using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("PicklistOrder")]
    public class PicklistOrderModel
    {
        public Guid GUIDPicklist { get; set; }
        public Guid GUIDPicklistOrder { get; set; }
        public Guid GUIDOrder { get; set; }
        public Guid? GUIDInvoice { get; set; }
        public Int32? Sequence { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string ContactEMailAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string PicklistID { get; set; }
        public string OrderID { get; set; }
        public string PicklistStatus { get; set; }
        public string StatusDescription { get; set; }
        public string OrderStatus { get; set; }
        public Guid? GUIDOrderWorkFlowStatus { get; set; }
        public string WorkFlowStatus { get; set; }
        public string PicklistIDSort { get; set; }
        public Int32 NothingPicked { get; set; }
    }
}
