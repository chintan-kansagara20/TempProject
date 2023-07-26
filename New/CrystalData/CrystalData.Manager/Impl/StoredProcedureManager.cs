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
    public class StoredProcedureManager : IStoredProcedureManager
    {
        private readonly IStoredProcedureDataAccess DataAccess = null;
        public StoredProcedureManager(IStoredProcedureDataAccess dataAccess)
        {
            DataAccess = dataAccess;
        }

        public APIResponse GetNextNumber(string NumberType)
        {
            var result = DataAccess.GetNextNumber(NumberType);
            if (result != null)
            {
                return new APIResponse(ResponseCode.SUCCESS, "Next Number Found", result);
            }
            else
            {
                return new APIResponse(ResponseCode.ERROR, "No Record Found");
            }
        }
    }
}
