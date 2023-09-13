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
    public interface ITbCustomerMarketingListXrefManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        APIResponse Insert(tbCustomerMarketingListXrefModel model);
        APIResponse Update(Guid GUIDListXref, tbCustomerMarketingListXrefModel model);
        APIResponse HardDelete(Guid GUIDListXref);
    }
}
