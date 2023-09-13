using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("PrinterAssignment")]
    public class PrinterAssignmentModel
    {
        public string ComputerName { get; set; } 
        public string ReportID { get; set; } 
        public string PrinterName { get; set; }
        public string PrinterDriver { get; set; }
        public string PrinterPort { get; set; }
        public Int32? DefaultSource { get; set; }
        public Int32? Duplex { get; set; }
    }
}
