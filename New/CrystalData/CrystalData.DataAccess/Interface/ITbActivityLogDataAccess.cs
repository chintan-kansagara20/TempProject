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
    public interface ITbActivityLogDataAccess
    {
        List<tbActivityLogModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbActivityLogModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Int32  PK, tbActivityLogModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Int32 PK, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
