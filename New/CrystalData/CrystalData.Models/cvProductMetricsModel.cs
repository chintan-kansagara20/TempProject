using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductMetrics")]
    public class cvProductMetricsModel
    {
        public string MetricsProductID { get; set; } 
        public string MetricsDescription { get; set; }
        public string MetricsProductType { get; set; } 
        public string MetricsProductTypeDescription { get; set; }
        public string MetricsSalesCategory { get; set; }
        public string FGSalesCategoryDescription { get; set; }
        public Boolean FGActiveStatus { get; set; }
        public string MetricsGroup { get; set; }
        public string MetricsMethod { get; set; }
        public string MetricsSpec { get; set; }
        public string MetricsType { get; set; }
        public string MetricsTechSpec { get; set; }
        public string MetricsWebAddress { get; set; }
        public Guid MetricsGUID { get; set; } 
    }
}
