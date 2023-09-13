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
    public interface ITbEDIImportLogDataAccess
    {
        List<tbEDIImportLogModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbEDIImportLogModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Int32 PKIDEDIImportLog, tbEDIImportLogModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Int32 PKIDEDIImportLog, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
