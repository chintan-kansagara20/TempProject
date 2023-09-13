using CrystalData.Models;
using EasyCrudLibrary.Model;
using EasyCrudLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.DataAccess.Interface
{
    public interface ITbAccessPermissionGroupDataAccess
    {
        List<tbAccessPermissionGroupModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbAccessPermissionGroupModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(string PermissionGroup, tbAccessPermissionGroupModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(string PermissionGroup, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
