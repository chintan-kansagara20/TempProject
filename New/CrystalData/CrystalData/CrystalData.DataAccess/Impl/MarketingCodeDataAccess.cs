using AuthLayer.Utility;
using CrystalData.Models;
using EasyCrudLibrary.Model;
using EasyCrudLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using CrystalData.DataAccess.Interface;

namespace CrystalData.DataAccess.Impl
{
    public class MarketingCodeDataAccess : IMarketingCodeDataAccess
    {
        private string ConnectionString { get; set; }
        private CommonFunctions _cf { get; set; }

        public MarketingCodeDataAccess(IHostingEnvironment env, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            try
            {
                _cf = new CommonFunctions(configuration, env.ContentRootPath, httpContextAccessor);
                ConnectionString = _cf.GetNewConnectionString();
            }
            catch (Exception) { }
        }

        public List<MarketingCodeModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList)
        {
            var _EC = new EasyCrud(ConnectionString);

            string WhereCondition = "";
            string FilterCondtion = DataAccessHelper.ConvertAdvanceFilterToConditionString(filtersList);
            if (!String.IsNullOrEmpty(FilterCondtion))
            {
                WhereCondition += " WHERE " + FilterCondtion;
            }

            var FinalReturn = _EC.GetList<MarketingCodeModel>(page, itemsPerPage, orderBy, WhereCondition, null, GSEnums.WithInQuery.NoLock);
            return FinalReturn;
        }

        public int GetTotal(List<AdvanceFilterByModel> filtersList)
        {
            var _EC = new EasyCrud(ConnectionString);

            string WhereCondition = "";
            string FilterCondtion = DataAccessHelper.ConvertAdvanceFilterToConditionString(filtersList);
            if (!String.IsNullOrEmpty(FilterCondtion))
            {
                WhereCondition += " WHERE " + FilterCondtion;
            }

            var total = _EC.Count<MarketingCodeModel>(WhereCondition, null, GSEnums.WithInQuery.NoLock);
            return total;
        }
    }
}
