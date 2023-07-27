using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvIssuesForMfg")]
    public class cvIssuesForMfgModel
    {
        public Int32? Session { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string AOReference { get; set; }
        public string Document { get; set; }
        public Int32? DocumentNum { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string OrderNumber { get; set; }
        public string CustId { get; set; }
        public string AODescription { get; set; }
        public string ProductionWorkflowStatus { get; set; }
        public string AOProductId { get; set; }
        public string AOProductDescription { get; set; }
        public string AOProductType { get; set; }
        public Decimal? AOQuantity { get; set; }
        public string AOUnit { get; set; }
        public string AOProductSalesCategory { get; set; }
        public Int32? FPARegNum { get; set; }
        public string FPADocument { get; set; }
        public string FPAReference { get; set; }
        public string FPADescription { get; set; }
        public string FProductID { get; set; }
        public string FProductType { get; set; }
        public string FProductSalesCategory { get; set; }
        public string AlternateProductID { get; set; }
        public string UPC { get; set; }
        public string FProductDescription { get; set; }
        public string LotNumber { get; set; }
        public string WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public Byte? PostedToGL { get; set; }
        public Byte? PostedToINV { get; set; }
        public Int32? TransactionNumber { get; set; }
        public Int32 parent { get; set; } 
        public Int32? NumSiblings { get; set; }
        public string IssueID { get; set; }
        public DateTime? DateDue { get; set; }
        public DateTime? DateOpened { get; set; }
        public string IssueDescription { get; set; }
        public string AssignedTo { get; set; }
        public Boolean IssueCompleted { get; set; }
        public string IssueType { get; set; }
        public string IssueTypeDescription { get; set; }
        public string IssueStatusDescription { get; set; }
        public string AssignedToName { get; set; }
    }
}
