using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvIngredientClaimActivities")]
    public class cvIngredientClaimActivitiesModel
    {
        public string ProductID { get; set; } 
        public Guid GUIDProduct { get; set; } 
        public string Description { get; set; }
        public string claims { get; set; }
        public Guid? GUIDIssue { get; set; }
        public string IssueID { get; set; }
        public string IssueType { get; set; }
        public DateTime? effective_date { get; set; }
        public DateTime? expiration_date { get; set; }
        public string VendorName { get; set; }
        public Guid? GUIDVendor { get; set; }
    }
}
