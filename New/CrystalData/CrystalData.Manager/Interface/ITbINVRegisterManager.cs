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
    public interface ITbINVRegisterManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        APIResponse Insert(tbINVRegisterModel model);
        APIResponse Update(Guid GUIDINVRegister, tbINVRegisterModel model);
        APIResponse Delete(Guid GUIDINVRegister);
        APIResponse HardDelete(Guid GUIDINVRegister);
    }
}
