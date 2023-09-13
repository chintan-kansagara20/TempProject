using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("OrderPackages")]
    public class OrderPackagesModel
    {
        public Decimal? CODAmount { get; set; }
        public string Comment { get; set; }
        public Decimal? DeclaredValue { get; set; }
        public Boolean? FreightCollect { get; set; }
        public Boolean? Insured { get; set; }
        public Decimal? ShippingCharge { get; set; }
        public string TrackingNumber { get; set; }
        public Boolean Voided { get; set; }
        public Decimal? Weight { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public Boolean NotBillable { get; set; }
        public string Carrier { get; set; }
        public string CarrierService { get; set; }
        public Decimal? HandlingCharge { get; set; }
        public string OrderNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public Guid GUIDOrder { get; set; }
        public Guid GUIDShipmentPack { get; set; }
        public Guid? GUIDShipment { get; set; }
        public Guid? GUIDInvoice { get; set; }
    }
}
