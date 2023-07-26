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
    public interface ITbINVLotSerialDataAccess
    {
        List<tbINVLotSerialModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbINVLotSerialModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Guid GUIDINVLotSerial, tbINVLotSerialModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Guid GUIDINVLotSerial, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
