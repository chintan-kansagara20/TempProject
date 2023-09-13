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
    public interface ITbContractTypeManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        APIResponse Insert(tbContractTypeModel model);
        APIResponse Update(Guid GUIDContractType, tbContractTypeModel model);
        APIResponse HardDelete(Guid GUIDContractType);
    }
}
