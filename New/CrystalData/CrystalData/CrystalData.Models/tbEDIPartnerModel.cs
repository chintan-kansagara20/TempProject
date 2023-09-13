using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbEDIPartner")]
    public class tbEDIPartnerModel
    {
        public Guid GUIDPartner { get; set; }
        public string PartnerIDQualifier { get; set; }
        public string PartnerID { get; set; }
        public string PartnerName { get; set; }
        public string PartnerVendorID { get; set; }
        public string PartnerType { get; set; }
        public string OurIDQualifier { get; set; }
        public string OurID { get; set; }
        public string MailBoxInPath { get; set; }
        public string MailBoxInFileMask { get; set; }
        public string MailBoxInFileExt { get; set; }
        public string MailBoxOutPath { get; set; }
        public string MailBoxOutFileMask { get; set; }
        public string MailBoxOutFileExt { get; set; }
        public Boolean FTPEnabled { get; set; } = true;
        public string EDIServiceProvider { get; set; }
        public string FTPUser { get; set; }
        public string FTPPassword { get; set; }
        public string FTPServerIn { get; set; }
        public string FTPServerOut { get; set; }
        public string Usage { get; set; } 
        public Boolean ConsolidateShipments { get; set; } = true;
        public Int32? ICN { get; set; }
        public Boolean UseSFTP { get; set; } = true;
        public Int32 FTPPort { get; set; } = ((21));
    }
}
