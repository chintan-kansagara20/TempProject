using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("Shipment")]
    public class ShipmentModel
    {
        public Guid GUIDShipment { get; set; } 
        public Guid GUIDCustomer { get; set; } 
        public string ShipmentNumber { get; set; }
        public string ShipmentNumberSort { get; set; }
        public string ShipmentStructure { get; set; }
        public string ShipmentStatus { get; set; } 
        public Boolean ReadyToPrint { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public string ShipmentCreatedBy { get; set; }
        public DateTime? ShipmentCreatedDate { get; set; }
        public string ShipmentUpdatedBy { get; set; }
        public DateTime? ShipmentUpdatedDate { get; set; }
        public string ShipmentPackagingCode { get; set; }
        public Int32? ShipmentNumberOfPieces { get; set; }
        public Decimal? ShipmentGrossWeight { get; set; }
        public string ShipmentGrossWeightUnit { get; set; }
        public string FOB { get; set; }
        public string Carrier { get; set; }
        public string SCACCode { get; set; }
        public string CarrierDescription { get; set; }
        public string CarrierService { get; set; }
        public string CarrierReference { get; set; }
        public string TransportationTypeCode { get; set; }
        public string TransportationTypeName { get; set; }
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
        public Int32? PackageNumber { get; set; }
        public Decimal? PackageWeight { get; set; }
        public string PackageWeightUnit { get; set; }
        public Int32? OuterPack { get; set; }
        public Int32? InnerPack { get; set; }
        public string PackagePackagingCode { get; set; }
        public string TrackingNumber { get; set; }
        public string PackageID { get; set; }
        public string OrderNumber { get; set; }
        public string Customer { get; set; }
        public string PO { get; set; }
        public string StoreLocation { get; set; }
        public string Reference { get; set; }
        public string Reference2 { get; set; }
        public Int32? LineNumber { get; set; }
        public Decimal? Quantity { get; set; }
        public string ProductUnit { get; set; }
        public string ProductID { get; set; }
        public string BuyerProductID { get; set; }
        public string UPC { get; set; }
        public string Description { get; set; }
        public string Warehouse { get; set; }
        public string ShippingInstructions { get; set; }
        public string Department { get; set; }
        public string VendorNumber { get; set; }
        public Decimal? ProductAltWeight { get; set; }
        public Decimal? ProductAltLength { get; set; }
        public Decimal? ProductAltHeight { get; set; }
        public Decimal? ProductAltWidth { get; set; }
        public Decimal? ProductAltVolume { get; set; }
    }
}
