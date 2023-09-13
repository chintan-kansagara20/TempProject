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
    public interface ITbCustomerShipToInfoDataAccess
    {
        List<tbCustomerShipToInfoModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbCustomerShipToInfoModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Guid GUIDLocation, tbCustomerShipToInfoModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Guid GUIDLocation, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
