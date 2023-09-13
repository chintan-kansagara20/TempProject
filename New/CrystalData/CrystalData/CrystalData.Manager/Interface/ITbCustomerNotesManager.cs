using AuthLayer.Utility;
using CrystalData.Models;
using EasyCrudLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Manager.Interface
{
    public interface ITbCustomerNotesManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        APIResponse Insert(tbCustomerNotesModel model);
        APIResponse Update(Int32 PKIDCustomerNotes, tbCustomerNotesModel model);
        APIResponse HardDelete(Int32 PKIDCustomerNotes);
    }
}
