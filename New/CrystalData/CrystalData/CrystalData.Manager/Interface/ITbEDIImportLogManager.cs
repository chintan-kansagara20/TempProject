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
    public interface ITbEDIImportLogManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        APIResponse Insert(tbEDIImportLogModel model);
        APIResponse Update(Int32 PKIDEDIImportLog, tbEDIImportLogModel model);
        APIResponse HardDelete(Int32 PKIDEDIImportLog);
    }
}
