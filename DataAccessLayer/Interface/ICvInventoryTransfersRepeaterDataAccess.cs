using EasyCrudLibrary.Model;
using Models;

namespace DataAccessLayer.Interface
{
    public interface ICvInventoryTransfersRepeaterDataAccess
    {
        List<cvInventoryTransfersRepeaterModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
    }
}
