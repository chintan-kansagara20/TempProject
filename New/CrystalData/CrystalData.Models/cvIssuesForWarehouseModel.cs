using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvIssuesForWarehouse")]
    public class cvIssuesForWarehouseModel
    {
        public string IssueID { get; set; }
        public string AssignedTo { get; set; }
        public Boolean Completed { get; set; }
        public Int32? RegNumber { get; set; }
        public string LotNumber { get; set; }
        public string Reference { get; set; }
        public string Specification { get; set; }
        public string Location { get; set; }
        public string ProductID { get; set; }
        public Decimal? QtyReceived { get; set; }
        public string Unit { get; set; }
    }
}
