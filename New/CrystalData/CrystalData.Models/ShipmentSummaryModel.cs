using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ShipmentSummary")]
    public class ShipmentSummaryModel
    {
        public Guid GUIDShipment { get; set; } 
        public Guid GUIDCustomer { get; set; } 
        public string ShipmentNumber { get; set; }
        public string ShipmentStatus { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public DateTime? ScheduledDeliveryDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Boolean ReadyToPrint { get; set; }
        public Boolean Printed { get; set; }
        public Boolean Exported856 { get; set; }
        public DateTime? Exported856Date { get; set; }
        public string PackagingCode { get; set; }
        public Int32? NumberOfPieces { get; set; }
        public Decimal? GrossWeight { get; set; }
        public string GrossWeightUnit { get; set; }
        public string Carrier { get; set; }
        public string CarrierService { get; set; }
        public string CarrierReference { get; set; }
        public string TransportationType { get; set; }
        public string Routing { get; set; }
        public string BillOfLading { get; set; }
        public string ShipToAttn { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToAddress3 { get; set; }
        public string ShipToAddress4 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToZip { get; set; }
        public string ShipToCountry { get; set; }
        public string ShipToLocation { get; set; }
        public string ContactName { get; set; }
        public string ContactPhoneNumber { get; set; }
        public Decimal? CODAmount { get; set; }
        public Decimal? DeclaredValue { get; set; }
        public Decimal? ShippingCharge { get; set; }
        public Decimal? HandlingCharge { get; set; }
        public Boolean FreightCollect { get; set; }
        public Boolean Insured { get; set; }
        public Guid? GUIDInvoice { get; set; }
        public Guid? GUIDPartner { get; set; }
        public string WarehouseShipmentNumber { get; set; }
        public string WebShipmentID { get; set; }
        public DateTime? WebSyncDate { get; set; }
        public Guid? ShipWSGUIDTemplate { get; set; }
        public string ShipmentStructure { get; set; }
        public string CustomerID { get; set; }
        public string InvoiceNumber { get; set; }
        public Int32? NumberOfCartons { get; set; }
        public string SCACCode { get; set; }
        public string ShipToAddress { get; set; }
    }
}
