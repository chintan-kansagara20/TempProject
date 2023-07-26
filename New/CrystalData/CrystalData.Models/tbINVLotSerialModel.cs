using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbINVLotSerial")]
    public class tbINVLotSerialModel
    {
        public Guid GUIDINVLotSerial { get; set; }
        public Guid GUIDProduct { get; set; }
        public string Number { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Reference { get; set; }
        public string Location { get; set; }
        public string Specification { get; set; }
    }
}
