using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ShipmentPack")]
    public class ShipmentPackModel
    {
        public string ShipmentNumber { get; set; }
        public Guid GUIDCustomer { get; set; }
        public string CustomerID { get; set; }
        public Guid GUIDShipmentPack { get; set; } 
        public Guid? GUIDShipment { get; set; }
        public Int32? PackNumber { get; set; }
        public Decimal? QtyShipped { get; set; }
        public Decimal? Weight { get; set; }
        public string WeightUnit { get; set; }
        public Int32? OuterPack { get; set; }
        public Int32? InnerPack { get; set; }
        public string PackagingCode { get; set; }
        public string CarrierPackageID { get; set; }
        public string PackageID { get; set; }
        public string StoreLocation { get; set; }
        public Boolean Voided { get; set; }
        public DateTime? VoidDate { get; set; }
        public Boolean NotBillable { get; set; }
        public string Comment { get; set; }
        public Decimal? CODAmount { get; set; }
        public Decimal? DeclaredValue { get; set; }
        public Decimal? ShippingCharge { get; set; }
        public Decimal? HandlingCharge { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public string WebPackageID { get; set; }
        public string ShipWSPackageID { get; set; }
        public string PackageIDWithAI { get; set; }
        public Guid? GUIDOrder { get; set; }
        public string OrderNumber { get; set; }
        public string PO { get; set; }
    }
}
