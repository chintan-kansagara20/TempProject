using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvAssemblyProductionReportInner")]
    public class cvAssemblyProductionReportInnerModel
    {
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public string Document { get; set; }
        public Int32? DocumentNumber { get; set; }
        public string OrderNumber { get; set; }
        public string WarehouseID { get; set; }
        public Decimal? LaborCleaningBatching { get; set; }
        public Decimal? LaborBatchingSetup { get; set; }
        public Decimal? LaborBatching { get; set; }
        public Decimal? NumBatchWorkers { get; set; }
        public Decimal? BatchRunTime { get; set; }
        public Double? HoursPerPersonBatch { get; set; }
        public Decimal? LaborCleanWIP { get; set; }
        public Decimal? LaborWIPSetup { get; set; }
        public Decimal? LaborWIP { get; set; }
        public Decimal? NumWIPWorkers { get; set; }
        public Decimal? WIPRunTime { get; set; }
        public Double? HoursPerPersonWIP { get; set; }
        public Decimal? LaborCleanPackaging { get; set; }
        public Decimal? LaborPackagingSetup { get; set; }
        public Decimal? LaborPackaging { get; set; }
        public Decimal? NumPackagingWorkers { get; set; }
        public Decimal? PackRunTIme { get; set; }
        public Double? HoursPerPersonPack { get; set; }
        public Decimal? TotalLaborHours { get; set; }
        public Decimal? ActualRunTimeTotal { get; set; }
        public Decimal? FGQuantity { get; set; }
        public Decimal? UnlabelledQuantity { get; set; }
        public Decimal? WIPQuantity { get; set; }
        public Decimal? BatchQuantity { get; set; }
        public Decimal? FGStandardLabor { get; set; }
        public Int32? FGPKIDINVTransactionParent { get; set; }
        public Int32? UnlabelledPKIDINVTransactionParent { get; set; }
        public Int32? WIPPKIDINVTransactionParent { get; set; }
        public Int32? BatchPKIDINVTransactionParent { get; set; }
        public Int32? MetricsPKIDINVTransactionParent { get; set; }
        public Int32? ProcPKIDINVTransactionParent { get; set; }
        public Int32? QCPKIDINVTransactionParent { get; set; }
        public Guid? FGGUIDOrderDatail { get; set; }
    }
}
