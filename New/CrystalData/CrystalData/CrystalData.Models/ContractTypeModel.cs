using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ContractType")]
    public class ContractTypeModel
    {
        public Guid GUIDContractType { get; set; }
        public string ContractType { get; set; }
        public string Description { get; set; }
        public Boolean IssueAlert { get; set; }
        public Boolean Active { get; set; }
    }
}
