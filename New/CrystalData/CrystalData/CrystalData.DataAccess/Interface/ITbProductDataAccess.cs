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
    public interface ITbProductDataAccess
    {
        List<tbProductModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbProductModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(string ProductID, tbProductModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(string ProductID, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
