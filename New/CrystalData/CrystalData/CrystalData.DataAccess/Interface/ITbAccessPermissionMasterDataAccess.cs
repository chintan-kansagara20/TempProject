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
    public interface ITbAccessPermissionMasterDataAccess
    {
        List<tbAccessPermissionMasterModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbAccessPermissionMasterModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(string Permission, tbAccessPermissionMasterModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(string Permission, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
