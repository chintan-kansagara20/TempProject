using AuthLayer.Utility;
using CrystalData.Models;
using EasyCrudLibrary.Model;

namespace CrystalData.Manager.Interface
{
    public interface ITbAccessPermissionManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        APIResponse Insert(tbAccessPermissionModel model);
        APIResponse Update(Guid GUIDAccessPermission, tbAccessPermissionModel model);
        APIResponse HardDelete(Guid GUIDAccessPermission);
    }
}
