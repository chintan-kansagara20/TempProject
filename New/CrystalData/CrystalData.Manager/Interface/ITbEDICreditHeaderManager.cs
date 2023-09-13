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
    public interface ITbEDICreditHeaderManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        APIResponse Insert(tbEDICreditHeaderModel model);
        APIResponse Update(Int32 PKIDEDICreditHeader, tbEDICreditHeaderModel model);
        APIResponse HardDelete(Int32 PKIDEDICreditHeader);
    }
}
