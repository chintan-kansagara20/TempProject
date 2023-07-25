using AuthLayer.Utility;
using DataAccessLayer.Interface;
using EasyCrudLibrary.Model;
using ManagersLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagersLayer.Impl
{
    public class CarrierVoidOptionsManager : ICarrierVoidOptionsManager
    {
        private readonly ICarrierVoidOptionsDataAccess DataAccess = null;
        public CarrierVoidOptionsManager(ICarrierVoidOptionsDataAccess dataAccess)
        {
            DataAccess = dataAccess;
        }

        public APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList)
        {
            var result = DataAccess.Get(page, itemsPerPage, orderBy, filtersList);
            if (result != null && result.Count > 0)
            {
                var totalRecords = DataAccess.GetTotal(filtersList);
                var response = new { records = result, pageNumber = page, pageSize = itemsPerPage, totalRecords = totalRecords };
                return new APIResponse(ResponseCode.SUCCESS, "Record Found", response);
            }
            else
            {
                return new APIResponse(ResponseCode.ERROR, "No Record Found");
            }
        }
    }
}
