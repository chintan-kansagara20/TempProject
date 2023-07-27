using AuthLayer.Utility;
using CrystalData.Models;
using EasyCrudLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Manager.Interface
{
    public interface ITbProductionWorkflowStatusManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        APIResponse Insert(tbProductionWorkflowStatusModel model);
        APIResponse Update(Guid GUIDProductionWorkflowStatus, tbProductionWorkflowStatusModel model);
        APIResponse HardDelete(Guid GUIDProductionWorkflowStatus);
    }
}
