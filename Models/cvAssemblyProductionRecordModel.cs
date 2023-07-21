using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
        [Table("cvAssemblyProductionRecord")]
        public class cvAssemblyProductionRecordModel
        {
            public Int32? RegNumber { get; set; }
            public Int32? OriginRegNumber { get; set; }
            public Int32? TransactionNumber { get; set; }
            public Int32? DocumentNumber { get; set; }
            public string BOMProductId { get; set; }
            public string BOMProductDescription { get; set; }
            public string BOMProductCategoryId { get; set; }
            public Int32 InitialSequence { get; set; }
            public string PRDetProductId { get; set; }
            public string PRDetProductDescription { get; set; }
            public Int32? PRDetSequence { get; set; }
            public string PRChildProductId { get; set; }
            public string PRChildProductDescription { get; set; }
            public Int32? PRChildSequence { get; set; }
            public Int32? ParentBomSequence { get; set; }
            public string parentproductID { get; set; }
            public string RowProductID { get; set; }
            public string RowProductDescription { get; set; }
            public string _ControlAssignTo { get; set; }
            public string Assignee { get; set; }
            public string _ControlActivityType { get; set; }
            public string ActivityType { get; set; }
            public string _ControlActivityStatus { get; set; }
            public string _ControlProductionWorkflow { get; set; }
            public string _ControlOrderWorkflowStatus { get; set; }
            public string ActivityStatus { get; set; }
            public Guid? AOBomGUIDProduct { get; set; }
            public Int32? PRRegNumber { get; set; }
            public Int32? PRTransactionNumber { get; set; }
            public Guid? PRGUIDINVTransactionDetail { get; set; }
            public Guid? PRDetGUIDINVTransactionDetail { get; set; }
            public Guid? PRDetGUIDProduct { get; set; }
            public Int32? PRChildRegNumber { get; set; }
            public Int32? PRChildTransactionNumber { get; set; }
            public Guid? PRChildGUIDINVTransactionDetail { get; set; }
            public Guid? PRChildGUIDProduct { get; set; }
            public Int32? RowRegNumber { get; set; }
            public Int32? RowTransactionNumber { get; set; }
            public Guid RowGUIDINVTransactionDetail { get; set; }
            public Guid? RowGUIDProduct { get; set; }
        }
    
}
