using AuthLayer.Utility;
using CrystalData.DataAccess.Interface;
using CrystalData.Manager.Interface;
using EasyCrudLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Manager.Impl
{
    public class CustomerPaymentManager : ICustomerPaymentManager
    {
        private readonly ICustomerPaymentDataAccess DataAccess = null;
        public CustomerPaymentManager(ICustomerPaymentDataAccess dataAccess)
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
