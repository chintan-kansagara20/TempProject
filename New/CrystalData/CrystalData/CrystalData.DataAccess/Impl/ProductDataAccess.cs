using AuthLayer.Utility;
using CrystalData.DataAccess.Interface;
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

namespace CrystalData.DataAccess.Impl
{
    public class ProductDataAccess : IProductDataAccess
    {
        private string ConnectionString { get; set; }
        private CommonFunctions _cf { get; set; }

        public ProductDataAccess(IHostingEnvironment env, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            try
            {
                _cf = new CommonFunctions(configuration, env.ContentRootPath, httpContextAccessor);
                ConnectionString = _cf.GetNewConnectionString();
            }
            catch (Exception) { }
        }

        public List<ProductModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList)
        {
            var _EC = new EasyCrud(ConnectionString);

            string WhereCondition = "";
            string FilterCondtion = DataAccessHelper.ConvertAdvanceFilterToConditionString(filtersList);
            if (!String.IsNullOrEmpty(FilterCondtion))
            {
                WhereCondition += " WHERE " + FilterCondtion;
            }

            var FinalReturn = _EC.GetList<ProductModel>(page, itemsPerPage, orderBy, WhereCondition, null, GSEnums.WithInQuery.NoLock);
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

            var total = _EC.Count<ProductModel>(WhereCondition, null, GSEnums.WithInQuery.NoLock);
            return total;
        }
    }
}
