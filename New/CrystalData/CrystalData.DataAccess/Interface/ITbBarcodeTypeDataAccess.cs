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
    public interface ITbBarcodeTypeDataAccess
    {
        List<tbBarcodeTypeModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbBarcodeTypeModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(string BarcodeTypeID, tbBarcodeTypeModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(string BarcodeTypeID, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
