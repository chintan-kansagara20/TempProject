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
    public interface ITbEDICreditHeaderDataAccess
    {
        List<tbEDICreditHeaderModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbEDICreditHeaderModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Int32 PKIDEDICreditHeader, tbEDICreditHeaderModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Int32 PKIDEDICreditHeader, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
