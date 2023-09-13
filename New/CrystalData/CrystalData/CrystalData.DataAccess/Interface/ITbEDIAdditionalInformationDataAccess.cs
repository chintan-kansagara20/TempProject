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
    public interface ITbEDIAdditionalInformationDataAccess
    {
        List<tbEDIAdditionalInformationModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbEDIAdditionalInformationModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Guid GUIDAdditionalInformation, tbEDIAdditionalInformationModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Guid GUIDAdditionalInformation, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
