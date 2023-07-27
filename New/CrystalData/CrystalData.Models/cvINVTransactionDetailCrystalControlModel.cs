using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvINVTransactionDetailCrystalControl")]
    public class cvINVTransactionDetailCrystalControlModel
    {
        public Int32 PKIDInvTransactionDetail { get; set; } 
        public Guid GUIDINVTransactionDetail { get; set; } 
        public Guid? GUIDINVLotSerial { get; set; }
        public string ProductID { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public string TransactionType { get; set; } 
        public Guid? GUIDProduct { get; set; }
        public string Description { get; set; }
        public Decimal? Quantity { get; set; }
        public Decimal? ComponentQuantity { get; set; }
        public Decimal? AssemblyQuantity { get; set; }
        public string Note { get; set; }
        public Byte[]? FSignature { get; set; }
        public Int32? Sequence { get; set; }
        public Boolean? VariableQuantity { get; set; }
        public Decimal? ParentQuantity { get; set; }
        public string ParentProductId { get; set; }
        public Guid? GUIDParentProduct { get; set; }
        public string ParentProductCategory { get; set; }
        public string ParentProductCategoryId { get; set; }
        public string itdProductCategory { get; set; }
        public string itdProductCategoryId { get; set; }
        public string itdProductSubCategory { get; set; }
    }
}
