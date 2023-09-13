using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyDocumentMembers")]
    public class cvAssemblyDocumentMembersModel
    {
        public Int32? OriginRegNumber { get; set; }
        public Int32? OriginTransactionNumber { get; set; }
        public Int32 OriginPKIDINVTransaction { get; set; }
        public Int32? DocumentNumber { get; set; }
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public Int32 MembersPKIDINVTransaction { get; set; }
    }
}
