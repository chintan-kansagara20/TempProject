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
    public interface ITbCustomerNotesDataAccess
    {
        List<tbCustomerNotesModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
        string Add(tbCustomerNotesModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool Update(Int32 PKIDCustomerNotes, tbCustomerNotesModel model, bool AutoCommit = true, EasyCrud _EC = null);
        bool HardDelete(Int32 PKIDCustomerNotes, bool AutoCommit = true, EasyCrud _EC = null);
    }
}
