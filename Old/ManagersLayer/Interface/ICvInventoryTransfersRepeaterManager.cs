using AuthLayer.Utility;
using EasyCrudLibrary.Model;

namespace ManagersLayer.Interface
{
    public interface ICvInventoryTransfersRepeaterManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
    }
}
