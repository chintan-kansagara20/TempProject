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
    public interface ITbCustomFieldDataAccess
    {
        List<tbCustomFieldModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbCustomFieldModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(string GUIDCustomField, tbCustomFieldModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(string GUIDCustomField, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
