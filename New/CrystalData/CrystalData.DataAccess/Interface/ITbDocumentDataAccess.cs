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
    public interface ITbDocumentDataAccess
    {
        List<tbDocumentModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbDocumentModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Guid GUIDDocument, tbDocumentModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Guid GUIDDocument, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
