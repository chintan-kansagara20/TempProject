using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyParent")]
    public class cvAssemblyParentModel
    {
        public Int32? RegNumber { get; set; }
        public string OpenedBy { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Source { get; set; }
        public DateTime? DatePostedToINV { get; set; }
        public string PostedToINVBy { get; set; }
        public Int16? TransactionPeriod { get; set; }
        public Int16? TransactionYear { get; set; }
        public DateTime? VoidedDate { get; set; }
        public string VoidedBy { get; set; }
        public Int32? TransactionNumber { get; set; }
        public string Document { get; set; }
        public string Reference { get; set; }
        public string DocumentType { get; set; }
        public DateTime? DocumentDate { get; set; }
        public Guid? GUIDGLInventoryAccount { get; set; }
        public Guid? GUIDGLOffsetAccount { get; set; }
        public DateTime? InProgressDate { get; set; }
        public Decimal ExchangeRate { get; set; } 
        public Boolean PostedToINV { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string productid { get; set; }
        public Decimal? Quantity { get; set; }
        public Decimal? AssemblyQuantity { get; set; }
        public string Location { get; set; }
        public string TransactionType { get; set; }
        public string TransactionProductDescription { get; set; }
        public string Unit { get; set; }
        public Decimal? UnitCost { get; set; }
        public Decimal? Amount { get; set; }
        public Int32? CostLayer { get; set; }
        public string LotNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string LotReference { get; set; }
        public string LotSpecification { get; set; }
        public string ProductDescription { get; set; }
        public string ProductUnit { get; set; }
        public string ProductCategory { get; set; }
        public string ProductCategoryId { get; set; }
        public string ProductSubCategory { get; set; }
        public string ProductType { get; set; }
        public string ProductClassID { get; set; }
        public string SalesCategory { get; set; }
        public Int32? DocumentNumber { get; set; }
        public string ProductionWorkflowStatus { get; set; } 
        public string WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public Guid? GUIDAssociatedITD { get; set; }
        public Int32 PKIDINVRegister { get; set; } 
        public Guid GUIDINVRegister { get; set; } 
        public Int32 PKIDINVTransaction { get; set; } 
        public Guid GUIDINVTransaction { get; set; } 
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDOrderDetail { get; set; }
        public Guid? GUIDInProgressUser { get; set; }
        public Guid? GUIDWHLocation { get; set; }
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public Guid? GUIDINVTransactionDetail { get; set; }
        public Int32? PKIDINVTransactionDetail { get; set; }
        public Guid? GUIDLayerBatch { get; set; }
    }
}
