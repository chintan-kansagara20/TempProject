using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyOrderMembers")]
    public class cvAssemblyOrderMembersModel
    {
        public Int32? OriginRegNumber { get; set; }
        public Int32? OriginTransactionNumber { get; set; }
        public Int32 OriginPKIDINVTransaction { get; set; } 
        public string OriginDocument { get; set; }
        public Int32? FinishedProductTranasctionRegNumber { get; set; }
        public Int32? FinishedProductTranasctionNumber { get; set; }
        public Guid? FinishedProductGUIDINVTransaction { get; set; }
        public string FinishedProductID { get; set; }
        public Guid? FinishedProductGUIDProduct { get; set; }
        public Guid? FinishedProductHeaderGUIDInvTrxDet { get; set; }
        public Guid? GUIDOrderDetail { get; set; }
        public Int32? MemberRegNumber { get; set; }
        public Int32? MemberTransactionNumber { get; set; }
        public string MemberHeaderProductCategory { get; set; }
        public string MemberHeaderProductCategoryID { get; set; }
        public Int32? MemberHeaderSpecGroup { get; set; }
        public string MemberHeaderProductID { get; set; }
        public Guid? MemberHeaderGUIDProduct { get; set; }
        public Guid ComponentGUIDINVTransactionDetail { get; set; } 
        public string ComponentProductID { get; set; } 
        public Guid ComponentGUIDProduct { get; set; } 
        public string ComponentAssemblyType { get; set; }
        public string ComponentProductCategory { get; set; }
        public string ComponentProductCategoryID { get; set; }
        public Int32? ComponentSpecGroup { get; set; }
    }
}
