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
    public interface ITbINVRegisterDataAccess
    {
        List<tbINVRegisterModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbINVRegisterModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Guid GUIDINVRegister, tbINVRegisterModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool VoidRecord(Guid GUIDINVRegister, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Guid GUIDINVRegister, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
