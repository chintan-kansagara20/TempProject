using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("tbAccess")]
    public class tbAccessModel
    {
        public Guid GUIDAccess { get; set; }
        public string ID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public string EmailSignature { get; set; }
        public string BCCAddress { get; set; }
        public string MessageAddr { get; set; }
        public Boolean Active { get; set; } = true;
        public Guid? GUIDSalesperson { get; set; }
        public Boolean AutoOpenAlerts { get; set; } = true;
        public Boolean AutoOpenActivities { get; set; } = true;
        public Boolean AutoOpenSchedule { get; set; } = true;
        public string DefaultActivityType { get; set; }
        public string DefaultScheduleClass { get; set; }
        public Boolean AutoOpenDashboard { get; set; } = true;
        public Boolean AutoOpenOrderManager { get; set; } = true;
        public Boolean RestrictBySalesperson { get; set; } = true;
        public Boolean EmailSettingsOverride { get; set; } = true;
        public string SMTPServer { get; set; }
        public string SMTPUserName { get; set; }
        public string SMTPPassword { get; set; }
        public Int32? EmailType { get; set; }
        public Int32 SMTPEncryption { get; set; } = ((0));
        public Boolean SMTPAuthRequired { get; set; } = true;
        public Int32? PrevWhatsNew { get; set; }
        public Int32? LastWhatsNew { get; set; }
        public Boolean AutoOpenPOManager { get; set; } = true;
    }
}
