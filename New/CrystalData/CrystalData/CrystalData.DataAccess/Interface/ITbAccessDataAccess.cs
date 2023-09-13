using CrystalData.Models;
using EasyCrudLibrary;
using EasyCrudLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.DataAccess.Interface
{
    public interface ITbAccessDataAccess
    {
        List<tbAccessModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbAccessModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Guid GUIDAccess, tbAccessModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Guid GUIDAccess, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
