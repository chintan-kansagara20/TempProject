using System.ComponentModel.DataAnnotations.Schema;

namespace Models
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
