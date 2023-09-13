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
    public interface ITbCarrierDataAccess
    {
        List<tbCarrierModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbCarrierModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(string Carrier, tbCarrierModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(string Carrier, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
