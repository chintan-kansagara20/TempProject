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
    public interface ITbEDIImportStatusManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        APIResponse Insert(tbEDIImportStatusModel model);
        APIResponse Update(Int32 PKIDEDIImportStatus, tbEDIImportStatusModel model);
        APIResponse HardDelete(Int32 PKIDEDIImportStatus);
    }
}
