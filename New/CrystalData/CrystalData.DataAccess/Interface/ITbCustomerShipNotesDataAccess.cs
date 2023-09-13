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
    public interface ITbCustomerShipNotesDataAccess
    {
        List<tbCustomerShipNotesModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbCustomerShipNotesModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Guid GUIDLocation, tbCustomerShipNotesModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Guid GUIDLocation, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
