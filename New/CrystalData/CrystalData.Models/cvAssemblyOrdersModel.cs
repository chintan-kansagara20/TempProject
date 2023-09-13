using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyOrders")]
    public class cvAssemblyOrdersModel
    {
        public Int32? Session { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Reference { get; set; }
        public string Document { get; set; }
        public Int32? DocumentNum { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerPO { get; set; }
        public DateTime? OrderRequestedShipDate { get; set; }
        public string CustId { get; set; }
        public string CompanyName { get; set; }
        public string AODescription { get; set; }
        public string ProductionWorkflowStatus { get; set; }
        public string Location { get; set; }
        public string AOProductId { get; set; }
        public string AOProductDescription { get; set; }
        public Decimal? AOQuantity { get; set; }
        public Decimal? AOAssemblyQuantity { get; set; }
        public string AOUnit { get; set; }
        public string AOProductCategoryId { get; set; }
        public string AOProductSubCategory { get; set; }
        public string AOProductCategory { get; set; }
        public Decimal? AOProductSpecGroup { get; set; }
        public string AOProductType { get; set; }
        public string AOProductClassID { get; set; }
        public string AOProductSalesCategory { get; set; }
        public Int32? FPARegNum { get; set; }
        public Int32? FPATransactionNumber { get; set; }
        public string FPADocument { get; set; }
        public string FPAReference { get; set; }
        public string FPADescription { get; set; }
        public Decimal? FGQuantity { get; set; }
        public string AOControlDataType { get; set; }
        public string AOProductAssemblyType { get; set; }
        public string FProductAssemblyType { get; set; }
        public string FProductID { get; set; }
        public string FProductDescription { get; set; }
        public string FProductType { get; set; }
        public string FGProductCategory { get; set; }
        public string FProductCategoryID { get; set; }
        public string FProductSalesCategory { get; set; }
        public string AlternateProductID { get; set; }
        public string UPC { get; set; }
        public string LotNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public string FProductLotNumber { get; set; }
        public DateTime? FProductExpirationDate { get; set; }
        public Guid? FProductGUIDInvLotSerial { get; set; }
        public string WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseLocation { get; set; }
        public string WarehouseZone { get; set; }
        public Guid? AOGuidProduct { get; set; }
        public Guid? FProductGUIDProduct { get; set; }
        public Boolean PostedToGL { get; set; }
        public Boolean PostedToINV { get; set; }
        public DateTime? RegDate { get; set; }
        public string VoidedBy { get; set; }
        public DateTime? VoidedDate { get; set; }
        public Int32 parent { get; set; } 
        public Int32? NumSiblings { get; set; }
        public Guid? GUIDINVTransactionDetail { get; set; }
        public Int32? PKIDINVTransactionDetail { get; set; }
        public Guid GUIDINVTransaction { get; set; }
        public Int32 PKIDINVTransaction { get; set; } 
        public Guid? FPGUIDOrderDatail { get; set; }
        public Guid? FPAssyDetGUIDINVTransactionDetail { get; set; }
        public Guid? GUIDOrderDetail { get; set; }
        public Guid? GUIDOrder { get; set; }
        public Guid? GUIDCustomer { get; set; }
        public string IssueID { get; set; }
        public DateTime? DateDue { get; set; }
        public string AssignedTo { get; set; }
        public string IssueType { get; set; }
        public string IssueTypeDescription { get; set; }
        public string IssueStatus { get; set; }
        public string AssignedToName { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public Guid? GUIDProductionWorkflowStatus { get; set; }
        public Guid? GUIDIssue { get; set; }
        public DateTime? DatePostedToINV { get; set; }
    }
}
