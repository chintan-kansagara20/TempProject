using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbEDIPartnerTransaction")]
    public class tbEDIPartnerTransactionModel
    {
        public Guid GUIDPartnerTransaction { get; set; } 
        public Guid GUIDPartner { get; set; } 
        public string TransactionID { get; set; } 
        public string MailBoxPath { get; set; }
        public string MailBoxFileMask { get; set; }
        public string MailBoxFileExt { get; set; }
        public string UsageIndicator { get; set; } 
        public Boolean Enabled { get; set; }
        public string MenuName { get; set; } 
        public string OurAppCode { get; set; } 
        public string PartnerAppCode { get; set; } 
        public Int32? MenuOrder { get; set; }
    }
}
