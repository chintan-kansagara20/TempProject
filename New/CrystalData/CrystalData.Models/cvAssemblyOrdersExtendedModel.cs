using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyOrdersExtended")]
    public class cvAssemblyOrdersExtendedModel
    {
        public Int32? Session { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Reference { get; set; }
        public string Document { get; set; }
        public Int32? DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string VoidedBy { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerPO { get; set; }
        public DateTime? OrderRequestedShipDate { get; set; }
        public Decimal? QtyOrdered { get; set; }
        public Decimal? QtyShipped { get; set; }
        public string CustId { get; set; }
        public string CompanyName { get; set; }
        public string AODescription { get; set; }
        public string ProductionWorkflowStatus { get; set; } 
        public string AOProductId { get; set; }
        public string AOProductDescription { get; set; }
        public Decimal? AOQuantity { get; set; }
        public Decimal? AOAssemblyQuantity { get; set; }
        public string AOUnit { get; set; }
        public string LotNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string FProductLotNumber { get; set; }
        public DateTime? FProductExpirationDate { get; set; }
        public string WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public string Location { get; set; }
        public string AOProductCategory { get; set; }
        public string AOProductSubCategory { get; set; }
        public string AOProductCategoryId { get; set; }
        public Decimal? AOProductSpecGroup { get; set; }
        public string AOProductType { get; set; }
        public string AOProductSalesCategory { get; set; }
        public Int32? FGTrxRegNum { get; set; }
        public Int32? FGTrxTransactionNumber { get; set; }
        public string FGTrxDocument { get; set; }
        public string FGTrxReference { get; set; }
        public string FGTrxDescription { get; set; }
        public Decimal? FGQuantity { get; set; }
        public string FProductAssemblyType { get; set; }
        public string AOControlDataType { get; set; }
        public string FProductID { get; set; }
        public string FProductDescription { get; set; }
        public string UnlabelledProductID { get; set; }
        public string UnlabelledProductDescription { get; set; }
        public string WIPProductID { get; set; }
        public string WIPProductDescription { get; set; }
        public string BatchProductID { get; set; }
        public string BatchProductDescription { get; set; }
        public string MetricsProductID { get; set; }
        public string MetricsProductDescription { get; set; }
        public string ProcProductID { get; set; }
        public string ProcProductDescription { get; set; }
        public string QCProductID { get; set; }
        public string QCProductDescription { get; set; }
        public string FProductType { get; set; }
        public string FGProductCategory { get; set; }
        public string FProductCategoryID { get; set; }
        public string FProductSalesCategory { get; set; }
        public string AlternateProductID { get; set; }
        public string UPC { get; set; }
        public Guid? AOGuidProduct { get; set; }
        public Guid? FProductGUIDProduct { get; set; }
        public Boolean PostedToGL { get; set; }
        public Boolean PostedToINV { get; set; }
        public Int32? NumSiblings { get; set; }
        public Guid? GUIDOrder { get; set; }
        public Guid? GUIDCustomer { get; set; }
        public string IssueID { get; set; }
        public DateTime? DateDue { get; set; }
        public string AssignedTo { get; set; }
        public string IssueType { get; set; }
        public string IssueTypeDescription { get; set; }
        public string IssueStatus { get; set; }
        public string AssignedToName { get; set; }
        public Guid GUIDINVTransaction { get; set; } 
        public Int32 PKIDINVTransaction { get; set; } 
        public Guid? GUIDINVTransactionDetail { get; set; }
        public Int32? PKIDINVTransactionDetail { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? FGGUIDWarehouse { get; set; }
        public Guid? FGGUIDOrderDatail { get; set; }
        public Guid? GUIDOrderDetail { get; set; }
        public Guid? FPGUIDLotSerial { get; set; }
        public Guid? FGUIDProduct { get; set; }
        public Guid? UnlabelledGUIDProduct { get; set; }
        public Guid? WIPGUIDProduct { get; set; }
        public Guid? BatchGUIDProduct { get; set; }
        public Guid? MetricsGUIDProduct { get; set; }
        public Guid? ProcGUIDProduct { get; set; }
        public Guid? QCGUIDProduct { get; set; }
        public Int32? FGPKIDINVTransaction { get; set; }
        public Int32? UnlabelledPKIDINVTransaction { get; set; }
        public Int32? WIPPKIDINVTransaction { get; set; }
        public Int32? BatchPKIDINVTransaction { get; set; }
        public Int32? MetricsPKIDINVTransaction { get; set; }
        public Int32? ProcPKIDINVTransaction { get; set; }
        public Int32? QCPKIDINVTransaction { get; set; }
        public Int32? FGPKIDINVTransactionDetailParent { get; set; }
        public Int32? UnlabelledPKIDINVTransactionDetailParent { get; set; }
        public Int32? WIPPKIDINVTransactionDetailParent { get; set; }
        public Int32? BatchPKIDINVTransactionDetailParent { get; set; }
        public Int32? MetricsPKIDINVTransactionDetailParent { get; set; }
        public Int32? ProcPKIDINVTransactionDetailParent { get; set; }
        public Int32? QCPKIDINVTransactionDetailParent { get; set; }
    }
}
