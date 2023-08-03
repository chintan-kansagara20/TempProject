using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("Picklist")]
    public class PicklistModel
    {
        public Guid GUIDPicklist { get; set; } 
        public string PicklistID { get; set; }
        public string Description { get; set; }
        public Guid GUIDWarehouse { get; set; } 
        public string PicklistStatus { get; set; }
        public Decimal? Length { get; set; }
        public string LengthUnit { get; set; }
        public Decimal? Weight { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string BeingPickedBy { get; set; }
        public DateTime? BeingPickedDate { get; set; }
        public DateTime? PickStartDate { get; set; }
        public string PickedBy { get; set; }
        public DateTime? PickedDate { get; set; }
        public Boolean Printed { get; set; }
        public string Warehouse { get; set; }
        public string StatusDescription { get; set; }
        public Int32 Open { get; set; } 
        public string PicklistIDSort { get; set; }
        public Boolean? Completed { get; set; }
    }
}
