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
    public interface ITbEDIPartnerManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        APIResponse Insert(tbEDIPartnerModel model);
        APIResponse Update(Guid GUIDPartner, tbEDIPartnerModel model);
        APIResponse HardDelete(Guid GUIDPartner);
    }
}
