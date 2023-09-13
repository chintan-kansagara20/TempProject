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
    public interface ITbDocumentMgmtBarDataAccess
    {
        List<tbDocumentMgmtBarModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbDocumentMgmtBarModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Guid GUIDDocumentMgmtBar, tbDocumentMgmtBarModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Guid GUIDDocumentMgmtBar, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
