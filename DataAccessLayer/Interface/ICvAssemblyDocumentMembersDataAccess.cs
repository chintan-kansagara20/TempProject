using EasyCrudLibrary.Model;
using Models;

namespace DataAccessLayer.Interface
{
    public interface ICvAssemblyDocumentMembersDataAccess
    {
        List<cvAssemblyDocumentMembersModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        int GetTotal(List<AdvanceFilterByModel> filtersList);
    }
}
