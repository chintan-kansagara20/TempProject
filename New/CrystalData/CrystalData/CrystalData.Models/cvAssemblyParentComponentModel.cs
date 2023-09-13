using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyParentComponent")]
    public class cvAssemblyParentComponentModel
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
        public string ParentProductID { get; set; }
        public Decimal? ParentQuantity { get; set; }
        public Decimal? ParentAssemblyQuantity { get; set; }
        public string ParentLocation { get; set; }
        public string ParentTransactionType { get; set; }
        public string ParentProductDescriptionEdited { get; set; }
        public string ParentUnit { get; set; }
        public Decimal? ParentUnitCost { get; set; }
        public Decimal? ParentAmount { get; set; }
        public Int32? ParentCostLayer { get; set; }
        public string ParentLotNumber { get; set; }
        public DateTime? ParentLotExpirationDate { get; set; }
        public string ParentLotReference { get; set; }
        public string ParentLotSpecification { get; set; }
        public string ParentProductDescription { get; set; }
        public string ParentProductUnit { get; set; }
        public string ParentProductCategory { get; set; }
        public string ParentProductCategoryId { get; set; }
        public string ParentProductSubCategory { get; set; }
        public string ParentProductType { get; set; }
        public string ParentProductClassID { get; set; }
        public string ParentSalesCategory { get; set; }
        public Int32? DocumentNumber { get; set; }
        public string ProductionWorkflowStatus { get; set; } 
        public string ParentWarehouseID { get; set; }
        public string ParentWarehouseName { get; set; }
        public string ComponentProductID { get; set; }
        public Decimal? ComponentQuantity { get; set; }
        public Decimal? ComponentAssemblyQuantity { get; set; }
        public string ComponentLocation { get; set; }
        public string ComponentTransactionType { get; set; }
        public string ComponentProductDescriptionEdited { get; set; }
        public string ComponentUnit { get; set; }
        public Decimal? ComponentUnitCost { get; set; }
        public Decimal? ComponentAmount { get; set; }
        public Int32? ComponentCostLayer { get; set; }
        public string ComponentLotNumber { get; set; }
        public DateTime? ComponentLotExpirationDate { get; set; }
        public string ComponentLotReference { get; set; }
        public string ComponentLotSpecification { get; set; }
        public string ComponentProductDescription { get; set; }
        public string ComponentProductUnit { get; set; }
        public string ComponentProductCategory { get; set; }
        public string ComponentProductCategoryId { get; set; }
        public string ComponentProductSubCategory { get; set; }
        public string ComponentProductType { get; set; }
        public string ComponentProductClassID { get; set; }
        public string ComponentSalesCategory { get; set; }
        public string ComponentWarehouseID { get; set; }
        public string ComponentWarehouseName { get; set; }
        public Int32 PKIDINVRegister { get; set; } 
        public Guid GUIDINVRegister { get; set; } 
        public Int32 PKIDINVTransaction { get; set; } 
        public Guid GUIDINVTransaction { get; set; } 
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDOrderDetail { get; set; }
        public Guid? GUIDInProgressUser { get; set; }
        public Guid? ParentGUIDWHLocation { get; set; }
        public Guid? ParentGUIDProduct { get; set; }
        public Guid? ParentGUIDINVLotSerial { get; set; }
        public Guid? ParentGUIDINVTransactionDetail { get; set; }
        public Int32? ParentPKIDINVTransactionDetail { get; set; }
        public Guid? GUIDLayerBatch { get; set; }
        public Guid? ComponentGUIDWHLocation { get; set; }
        public Guid? ComponentGUIDProduct { get; set; }
        public Guid? ComponentGUIDINVLotSerial { get; set; }
        public Guid? ComponentGUIDINVTransactionDetail { get; set; }
        public Int32? ComponentPKIDINVTransactionDetail { get; set; }
        public Guid? ComponentGUIDLayerBatch { get; set; }
    }
}
