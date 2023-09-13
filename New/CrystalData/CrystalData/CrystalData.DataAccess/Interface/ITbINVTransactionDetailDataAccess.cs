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
    public interface ITbINVTransactionDetailDataAccess
    {
        List<tbINVTransactionDetailModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbINVTransactionDetailModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Guid GUIDINVTransactionDetail, tbINVTransactionDetailModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Guid GUIDINVTransactionDetail, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
