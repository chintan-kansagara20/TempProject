using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyDetails")]
    public class cvAssemblyDetailsModel
    {
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public string TransactionType { get; set; }
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public Decimal? Quantity { get; set; }
        public Decimal? AssemblyQuantity { get; set; }
        public Decimal? ComponentQuantity { get; set; }
        public string Unit { get; set; }
        public string LotNumber { get; set; }
        public string LotSpec { get; set; }
        public DateTime? LotExpirationDate { get; set; }
        public string LotReference { get; set; }
        public string PriceUnit { get; set; }
        public Decimal PriceUnitFactor { get; set; }
        public string ProductType { get; set; }
        public string ProductClassID { get; set; }
        public Boolean PostedToINV { get; set; }
        public string VoidedBy { get; set; }
        public Guid? GUIDProductClass { get; set; }
        public Guid GUIDProduct { get; set; }
        public Guid? GUIDWhLocation { get; set; }
        public Guid? GUIDINVLotSerial { get; set; }
        public Int32 PKIDINVTransactionDetail { get; set; }
        public Guid GUIDINVTransactionDetail { get; set; }
        public Guid GUIDINVTransaction { get; set; }
    }
}
