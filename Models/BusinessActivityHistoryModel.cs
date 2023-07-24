using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("BusinessActivityHistory")]
    public class BusinessActivityHistoryModel
    {
        public Guid? GUIDIssue { get; set; }
        public Int32 Completed { get; set; }
        public DateTime? Date { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedToName { get; set; }
        public string Type { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string ProductID { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public string Note { get; set; }
        public Decimal? Quantity { get; set; }
        public Decimal? Amount { get; set; }
    }
}
