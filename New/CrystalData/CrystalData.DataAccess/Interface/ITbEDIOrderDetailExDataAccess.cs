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
    public interface ITbEDIOrderDetailExDataAccess
    {
        List<tbEDIOrderDetailExModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbEDIOrderDetailExModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Guid GUIDOrderDetail, tbEDIOrderDetailExModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Guid GUIDOrderDetail, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
