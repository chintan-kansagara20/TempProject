using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblies")]
    public class cvAssembliesModel
    {
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Reference { get; set; }
        public string Document { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string AssemblyDescription { get; set; }
        public string ProductionWorkflowStatus { get; set; }
        public string ProductId { get; set; }
        public string ProductDescription { get; set; }
        public Decimal? Quantity { get; set; }
        public Decimal? AssemblyQuantity { get; set; }
        public string Unit { get; set; }
        public string LotNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public string ProductType { get; set; }
        public string ProductSalesCategory { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerPO { get; set; }
        public DateTime? OrderRequestedShipDate { get; set; }
        public string CustId { get; set; }
        public string CompanyName { get; set; }
        public Boolean PostedToGL { get; set; }
        public Boolean PostedToINV { get; set; }
        public string VoidedBy { get; set; }
        public DateTime? VoidedDate { get; set; }
        public Guid GUIDINVTransaction { get; set; }
        public Int32 PKIDINVTransaction { get; set; }
        public Guid? GUIDINVTransactionDetail { get; set; }
        public Int32? PKIDINVTransactionDetail { get; set; }
        public Guid? GUIDProduct { get; set; }
        public Guid? GUIDWarehouse { get; set; }
        public Guid? GUIDOrderDetail { get; set; }
        public Guid? GUIDOrder { get; set; }
        public Guid? GUIDCustomer { get; set; }
    }
}
