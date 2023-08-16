using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("System")]
    public class SystemModel
    {
        public Guid GUID { get; set; } 
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string WebAddress { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
        public string FAX { get; set; }
        public string DBVersion { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string EIN { get; set; }
        public string SSN { get; set; }
        public Int32? FirstMonthFiscalYear { get; set; }
        public Byte[]? Logo { get; set; }
        public string SMTPServer { get; set; }
        public string SMTPUserName { get; set; }
        public string SMTPPassword { get; set; }
        public Int32? EmailType { get; set; }
        public Int32 SMTPEncryption { get; set; } 
        public Boolean SMTPAuthRequired { get; set; }
        public string QBMSConnectionTicket { get; set; }
        public string QuickBooksCountry { get; set; }
        public DateTime? DemoBaseDate { get; set; }
        public DateTime? MetricsLastSentDate { get; set; }
        public Guid? GUIDHomeCurrency { get; set; }
        public string GUIHexColor { get; set; }
        public Boolean IsQBOnline { get; set; }
    }
}
