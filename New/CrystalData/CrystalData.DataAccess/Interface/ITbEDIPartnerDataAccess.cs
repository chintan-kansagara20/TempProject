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
    public interface ITbEDIPartnerDataAccess
    {
        List<tbEDIPartnerModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbEDIPartnerModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Guid GUIDPartner, tbEDIPartnerModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Guid GUIDPartner, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
