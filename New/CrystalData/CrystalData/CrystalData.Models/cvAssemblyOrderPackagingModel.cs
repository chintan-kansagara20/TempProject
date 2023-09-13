using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyOrderPackaging")]
    public class cvAssemblyOrderPackagingModel
    {
        public string PackageProductId { get; set; } 
        public string PackageProductDescription { get; set; }
        public Decimal? InnerPackQty { get; set; }
        public string Size { get; set; }
        public Int32? QtyEachPerBatch { get; set; }
        public Decimal? QtyPackagesPerBatch { get; set; }
        public Int32? QtyPerPackage { get; set; }
        public Int32? QtyInnerPacksPerPackage { get; set; }
        public Int32? Session { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Reference { get; set; }
        public string Document { get; set; }
        public Int32? DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string AODescription { get; set; }
        public string ProductionWorkflowStatus { get; set; } 
        public string AOProductId { get; set; }
        public string ProductId { get; set; }
        public string AOProductDescription { get; set; }
        public string ProductDescription { get; set; }
        public Decimal? AOQuantity { get; set; }
        public Decimal? Quantity { get; set; }
        public Decimal? AOAssemblyQuantity { get; set; }
        public Decimal? AssemblyQuantity { get; set; }
        public string AOUnit { get; set; }
        public string Unit { get; set; }
        public string LotNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string FProductLotNumber { get; set; }
        public DateTime? FProductExpirationDate { get; set; }
        public string WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public string AOProductCategory { get; set; }
        public string ProductCategory { get; set; }
        public string AOProductCategoryId { get; set; }
        public string ProductCategoryId { get; set; }
        public string AOProductType { get; set; }
        public string ProductType { get; set; }
        public string AOProductSalesCategory { get; set; }
        public string ProductSalesCategory { get; set; }
        public Int32? FGTrxRegNum { get; set; }
        public Int32? FGTrxTransactionNumber { get; set; }
        public string FGTrxDocument { get; set; }
        public string FGTrxReference { get; set; }
        public string FGTrxDescription { get; set; }
        public string FProductAssemblyType { get; set; }
        public string AOControlDataType { get; set; }
        public string ControlDataType { get; set; }
        public string FProductID { get; set; }
        public string FProductDescription { get; set; }
        public string FProductType { get; set; }
        public string FGProductCategory { get; set; }
        public string FProductCategoryID { get; set; }
        public string FProductSalesCategory { get; set; }
        public Guid? AOGuidProduct { get; set; }
        public Guid? GuidProduct { get; set; }
        public Guid? FProductGUIDProduct { get; set; }
        public Boolean PostedToGL { get; set; }
        public Boolean PostedToINV { get; set; }
        public string VoidedBy { get; set; }
        public DateTime? VoidedDate { get; set; }
        public Guid GUIDINVTransaction { get; set; } 
        public Int32 PKIDINVTransaction { get; set; } 
        public Guid? GUIDINVTransactionDetail { get; set; }
        public Int32? PKIDINVTransactionDetail { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? FGGUIDWarehouse { get; set; }
        public Guid? FGGUIDOrderDetail { get; set; }
        public Guid? FGUIDProduct { get; set; }
        public Decimal? FGQuantity { get; set; }
        public Int32? FGPKIDINVTransaction { get; set; }
        public Int32? FGPKIDINVTransactionParent { get; set; }
    }
}
