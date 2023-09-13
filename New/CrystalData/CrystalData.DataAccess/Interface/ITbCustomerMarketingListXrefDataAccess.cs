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
    public interface ITbCustomerMarketingListXrefDataAccess
    {
        List<tbCustomerMarketingListXrefModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbCustomerMarketingListXrefModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Guid GUIDListXref, tbCustomerMarketingListXrefModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Guid GUIDListXref, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
