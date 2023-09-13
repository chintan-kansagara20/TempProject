using AuthLayer.Utility;
using CrystalData.DataAccess.Interface;
using CrystalData.Manager.Interface;
using CrystalData.Models;
using EasyCrudLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Manager.Impl
{
    public class TbEDIImportLogManager : ITbEDIImportLogManager
    {
        private readonly ITbEDIImportLogDataAccess DataAccess = null;
        public TbEDIImportLogManager(ITbEDIImportLogDataAccess dataAccess)
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

        public APIResponse Insert(tbEDIImportLogModel model)
        {
            var result = DataAccess.Add(model);
            if (result != null)
            {
                return new APIResponse(ResponseCode.SUCCESS, "Record Inserted", result);
            }
            else
            {
                return new APIResponse(ResponseCode.ERROR, "No Record Found");
            }
        }

        public APIResponse Update(Int32 PKIDEDIImportLog, tbEDIImportLogModel model)
        {
            var result = DataAccess.Update(PKIDEDIImportLog, model);
            if (result)
            {
                return new APIResponse(ResponseCode.SUCCESS, "Record Updated", result);
            }
            else
            {
                return new APIResponse(ResponseCode.ERROR, "No Record Found");
            }
        }

        public APIResponse HardDelete(Int32 PKIDEDIImportLog)
        {
            var result = DataAccess.HardDelete(PKIDEDIImportLog);
            if (result)
            {
                return new APIResponse(ResponseCode.SUCCESS, "Record Deleted", result);
            }
            else
            {
                return new APIResponse(ResponseCode.ERROR, "No Record Found");
            }
        }
    }
}
